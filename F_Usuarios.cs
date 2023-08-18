using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CNegocio;


namespace DuDesk
{
    public partial class F_Usuarios : Fbase
    {
         E_USUARIO entidad = new E_USUARIO();
         N_USUARIO negocio = new N_USUARIO();
        public bool update = false;

        public F_Usuarios()
        {
            InitializeComponent();
           
            ListaEstados();
            ListaEmpleado();
            ListaNivel();
        }
        public void ListaEmpleado()
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            cbEmpleado.DataSource = negocio.ListandoEmpleados();
            cbEmpleado.ValueMember = "Id_Empleado";
            cbEmpleado.DisplayMember = "Nombre";
            cbEmpleado.SelectedIndex = -1;
          
        }
        public void ListaEstados()
        {
            Estado_Negocio negocio = new Estado_Negocio();
            cbEstado.DataSource = negocio.ListandoEstado();
            cbEstado.ValueMember = "Id_Estado";
            cbEstado.DisplayMember = "Nombre";
            cbEstado.SelectedIndex = -1;
        }
        public void ListaNivel() {
            NivelNegocio Nnegocio = new NivelNegocio();
            cbNivel.DataSource = Nnegocio.ListandoNivel();
            cbNivel.ValueMember = "Id_Nivel";
            cbNivel.DisplayMember = "Nombre";
            cbNivel.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                try
                {
                    entidad.IdEmpleado = Convert.ToInt32(cbEmpleado.SelectedValue);
                    entidad.Usuario = tb_Usuario.Text;
                    entidad.Clave = tb_Clave.Text;
                    entidad.IdNivel = Convert.ToInt32(cbNivel.SelectedValue);
                    entidad.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                  
                    negocio.InsertandoUsuarios(entidad);
                    MessageBox.Show("Usuario Guardado");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede guardar el Usuario" + ex.Message);

                }
            }
            if (update == true)
            {
                try
                {
                    entidad.IdUsuario = Convert.ToInt32(lb_id.Text);
                    entidad.IdEmpleado = Convert.ToInt32(cbEmpleado.SelectedValue);
                    entidad.Usuario = tb_Usuario.Text;
                    entidad.Clave = tb_Clave.Text;
                    entidad.IdNivel = Convert.ToInt32(cbNivel.SelectedValue);
                    entidad.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                    negocio.EditandoUsuarios(entidad);
                    MessageBox.Show("Usuario Editado");
                    Close();
                    update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el Usuario" + ex.Message);

                }
            }
        }

   
    }
}
