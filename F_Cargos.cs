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
    public partial class F_Cargos : Fbase

    {
        Cargo_Entidad CargEntidad = new Cargo_Entidad();
        Cargo_Negocio CargNegocio = new Cargo_Negocio();
        public F_Cargos()
        {
            InitializeComponent();
            ListaCargos();
        }
        public void ListaCargos()
        {
            Cargo_Negocio negocio = new Cargo_Negocio();
            cbCargo.DataSource = negocio.ListandoCargo();
            cbCargo.ValueMember = "Id_Cargo";
            cbCargo.DisplayMember = "Nombre";
            cbCargo.SelectedIndex = -1;
           

        }
        public void Clear() {
            tb_Cargo.Text = "";
            tb_Descripcion.Text = "";
            tb_Cargo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CargEntidad.Nombre = tb_Cargo.Text;
                CargEntidad.Descripcion = tb_Descripcion.Text;
                CargNegocio.InsertandoCargo(CargEntidad);
                MessageBox.Show("Cargo Guardado");
                Clear();
                ListaCargos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede guardar el Cargo" + ex.Message);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
                if (cbCargo.SelectedIndex > -1)
                {
                try {
                    if (MessageBox.Show("Estas seguro de eliminar el Cargo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string delete = cbCargo.Text;
                        CargNegocio.EliminandoCargo(delete);
                        MessageBox.Show("Cargo Eliminado!");
                        ListaCargos();
                    }
                }
                catch{
                    MessageBox.Show("Cargo no Eliminado!");
                }
            
                }
                else {
                    MessageBox.Show("Seleccione un Cargo que desea Eliminar");
                }
            
           
           
        }

       
    }
}
