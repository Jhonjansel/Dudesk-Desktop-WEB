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
    public partial class F_CatUsuarios : Fbase
    {
        public string IdUsuario;
         N_USUARIO negocio = new N_USUARIO();
        public F_CatUsuarios()
        {
            InitializeComponent();
        } 
        private void F_CatUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            TablaUsuarios.ClearSelection();
        }
        public void MostrarUsuarios()
        {
            
            TablaUsuarios.DataSource = negocio.ListandoUsuarios();

        }
        public void BuscarUsuarios(string buscar)
        {
           
            TablaUsuarios.DataSource = negocio.BuscandoUsuarios(buscar);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios(txtBuscar.Text);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            F_Usuarios fUsuarios = new F_Usuarios();
            fUsuarios.ShowDialog();
            fUsuarios.update = false;
            MostrarUsuarios();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            F_Usuarios F_editar = new F_Usuarios();
            if (TablaUsuarios.SelectedRows.Count > 0)
            {
                F_editar.update = true;
                F_editar.label1.Text = "Editar Usuarios";
                F_editar.lb_id.Text = TablaUsuarios.CurrentRow.Cells[0].Value.ToString();
                F_editar.cbEmpleado.Text = TablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                F_editar.tb_Usuario.Text = TablaUsuarios.CurrentRow.Cells[2].Value.ToString();
                F_editar.tb_Clave.Text = TablaUsuarios.CurrentRow.Cells[3].Value.ToString();
                F_editar.cbNivel.Text = TablaUsuarios.CurrentRow.Cells[4].Value.ToString();
                F_editar.cbEstado.Text = TablaUsuarios.CurrentRow.Cells[5].Value.ToString();

                F_editar.ShowDialog();
                MostrarUsuarios();
               
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaUsuarios.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("Estas seguro de eliminar el Usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int delete = Convert.ToInt32(TablaUsuarios.CurrentRow.Cells[0].Value.ToString());
                    negocio.EliminandoUsuarios(delete);
                    MessageBox.Show("Usuario Eliminado!");
                    MostrarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila que desea eliminar");
            }
        }
    }
}
