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
    public partial class F_CatProveedores : Fbase
    {
        public string IdProveedor;
        ProveedorNegocio negocio = new ProveedorNegocio();
        public F_CatProveedores()
        {
            InitializeComponent();
        }

        private void F_CatProveedores_Load(object sender, EventArgs e)
        {
            MostrarProveedores();

        }
        public void MostrarProveedores()
        {
            TablaProveedores.DataSource = negocio.ListandoProveedor();
        }
        public void BuscarProveedor(string name) {
            TablaProveedores.DataSource = negocio.BuscandoProveedor(name);
        
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProveedor(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            F_Proveedores fcrear = new F_Proveedores();
            fcrear.ShowDialog();
            fcrear.update = false;
            MostrarProveedores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            F_Proveedores f_editar = new F_Proveedores();

            if (TablaProveedores.SelectedRows.Count > 0)
            {
                f_editar.update = true;
                f_editar.label1.Text = "Editar Proveedores";
                f_editar.lb_id.Text = TablaProveedores.CurrentRow.Cells[0].Value.ToString();
                f_editar.tb_Nombre.Text = TablaProveedores.CurrentRow.Cells[1].Value.ToString();
                f_editar.tb_Identificacion.Text = TablaProveedores.CurrentRow.Cells[2].Value.ToString();
                f_editar.tb_Direccion.Text = TablaProveedores.CurrentRow.Cells[3].Value.ToString();
                f_editar.tb_Telefono.Text = TablaProveedores.CurrentRow.Cells[4].Value.ToString();
                f_editar.tb_Correo.Text = TablaProveedores.CurrentRow.Cells[5].Value.ToString();
                f_editar.dt_Registro.Text = TablaProveedores.CurrentRow.Cells[6].Value.ToString();
                f_editar.ShowDialog();
                MostrarProveedores();

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaProveedores.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("Estas seguro de eliminar el Proveedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int delete = Convert.ToInt32(TablaProveedores.CurrentRow.Cells[0].Value.ToString());
                    negocio.EliminandoProveedor(delete);
                    MessageBox.Show("Proveedor Eliminado!");
                    MostrarProveedores();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila que desea eliminar");
            }
        }
    }
}
