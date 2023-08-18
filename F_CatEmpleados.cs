using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;

namespace DuDesk
{
    public partial class F_CatEmpleados : Fbase
    {

        public string IdEmpleado;
        readonly EmpleadoNegocio negocio = new EmpleadoNegocio();
        public F_CatEmpleados()
        {
            InitializeComponent();
           
        } 
        private void F_CatEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            TablaEmpleados.ClearSelection();
        }


       
        public void MostrarEmpleados()
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            TablaEmpleados.DataSource = negocio.ListandoEmpleados();
          
        }
        public void BuscarEmpleado(string buscar)
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            TablaEmpleados.DataSource = negocio.BuscandoEmpleados(buscar);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleado(txtBuscar.Text);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            F_Empleados f_create = new F_Empleados();
            f_create.ShowDialog();
            f_create.update = false;
            MostrarEmpleados();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            F_Empleados fcrear = new F_Empleados();
            if (TablaEmpleados.SelectedRows.Count > 0)
            {
                fcrear.update = true;
                fcrear.label1.Text = "Editar Empleado"; 
                fcrear.lb_id.Text = TablaEmpleados.CurrentRow.Cells[0].Value.ToString();
                fcrear.tb_Nombre.Text = TablaEmpleados.CurrentRow.Cells[1].Value.ToString();
                fcrear.tb_Apellidos.Text = TablaEmpleados.CurrentRow.Cells[2].Value.ToString();
                if (TablaEmpleados.CurrentRow.Cells[3].Value.ToString() == "M")
                {
                    fcrear.rbtn_M.Checked = true;
                }
                else
                {
                    fcrear.rbtn_F.Checked = true;
                }
                fcrear.dt_Naci.Text = TablaEmpleados.CurrentRow.Cells[4].Value.ToString();
                fcrear.tb_Direccion.Text = TablaEmpleados.CurrentRow.Cells[5].Value.ToString();
                fcrear.tb_Telefono.Text = TablaEmpleados.CurrentRow.Cells[6].Value.ToString();
                fcrear.tb_Correo.Text = TablaEmpleados.CurrentRow.Cells[7].Value.ToString();
                fcrear.cbCargo.Text = TablaEmpleados.CurrentRow.Cells[8].Value.ToString();
                fcrear.cbEstado.Text = TablaEmpleados.CurrentRow.Cells[9].Value.ToString();
                fcrear.dt_Registro.Text = TablaEmpleados.CurrentRow.Cells[10].Value.ToString();
                fcrear.ShowDialog();
                MostrarEmpleados();
            }
            else {
                MessageBox.Show("Seleccione la fila que desea editar");
            }

          
      
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaEmpleados.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("Estas seguro de eliminar el Empleado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int delete = Convert.ToInt32(TablaEmpleados.CurrentRow.Cells[0].Value.ToString());
                    negocio.EliminandoEmpleado(delete);
                    MessageBox.Show("Empleado Eliminado!");
                    MostrarEmpleados();
                }
            }
            else {
                MessageBox.Show("Seleccione una fila que desea eliminar");
            }
        }

       
    }
}
