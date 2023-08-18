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
    public partial class F_Empleados : Fbase
    {
        readonly EmpleadoEntidad entidad = new EmpleadoEntidad();
        readonly EmpleadoNegocio negocio = new EmpleadoNegocio();
        public bool update = false;
     

        public F_Empleados()
        {
            InitializeComponent(); 
            ListaCargos();
            ListaEstados();
        }
        public void ListaCargos() {
            Cargo_Negocio negocio = new Cargo_Negocio();
            cbCargo.DataSource = negocio.ListandoCargo();
            cbCargo.ValueMember = "Id_Cargo";
            cbCargo.DisplayMember = "Nombre";
            cbCargo.SelectedIndex = -1;

        }
        public void ListaEstados() {
            Estado_Negocio negocio = new Estado_Negocio();
            cbEstado.DataSource = negocio.ListandoEstado();
            cbEstado.ValueMember = "Id_Estado";
            cbEstado.DisplayMember = "Nombre";
            cbEstado.SelectedIndex = -1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (update == false) {
                try {
                    entidad.Nombre = tb_Nombre.Text;
                    entidad.Apellidos = tb_Apellidos.Text;
                    if (rbtn_M.Checked == true) {
                        entidad.Sexo = "M";
                    }
                    if (rbtn_F.Checked == true)
                    {
                        entidad.Sexo = "F";
                    }
                    entidad.FechaNaci = dt_Naci.Value;
                    entidad.Direccion = tb_Direccion.Text;
                    entidad.Telefono = tb_Telefono.Text;
                    entidad.Correo = tb_Correo.Text;
                    entidad.IdCargo = Convert.ToInt32(cbCargo.SelectedValue);
                    entidad.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                    entidad.FechaRegi = dt_Registro.Value;
                    negocio.InsertandoEmpleados(entidad);
                    MessageBox.Show("Empleado Guardado");
                    Close();
                }
                catch (Exception ex) {
                    MessageBox.Show("No se puede guardar el Empleado"+ex.Message);

                }
            }
            if (update == true)
            {
                try
                {
                    entidad.IdEmpleado = Convert.ToInt32(lb_id.Text);
                    entidad.Nombre = tb_Nombre.Text;
                    entidad.Apellidos = tb_Apellidos.Text;
                    if (rbtn_M.Checked == true)
                    {
                        entidad.Sexo = "M";
                    }
                    if (rbtn_F.Checked == true)
                    {
                        entidad.Sexo = "F";
                    }
                    entidad.FechaNaci = dt_Naci.Value;
                    entidad.Direccion = tb_Direccion.Text;
                    entidad.Telefono = tb_Telefono.Text;
                    entidad.Correo = tb_Correo.Text;
                    entidad.IdCargo = Convert.ToInt32(cbCargo.SelectedValue);
                    entidad.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                    entidad.FechaRegi = dt_Registro.Value;
                    negocio.EditandoEmpleados(entidad);
                    MessageBox.Show("Empleado Editado");
                    Close();
                    update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el Empleado"+ex.Message);

                }
            }



        }

      
    }
}
