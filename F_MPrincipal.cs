using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuDesk
{
    public partial class F_MPrincipal : Form
    {
        

        public F_MPrincipal()
        {
            InitializeComponent();
        }

       
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

   

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void AgregarEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Empleados empleados = new F_Empleados();
            empleados.MdiParent = this;
            empleados.Show();
        }

        private void CatalogoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CatEmpleados catalogoEmpleado = new F_CatEmpleados();
            catalogoEmpleado.MdiParent = this;
            catalogoEmpleado.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AgregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Usuarios AddUser = new F_Usuarios();
            AddUser.MdiParent = this;
            AddUser.Show();
        }

        private void CatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CatUsuarios catUsuarios = new F_CatUsuarios();
            catUsuarios.MdiParent = this;
            catUsuarios.Show();
        }

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Cargos Fcargo = new F_Cargos();
            Fcargo.MdiParent = this;
            Fcargo.Show();
        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Clientes FCliente = new F_Clientes();
            FCliente.MdiParent = this;
            FCliente.Show();
        }

        private void CatalogoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CatClientes FCatClientes = new F_CatClientes();
            FCatClientes.MdiParent = this;
            FCatClientes.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Proveedores Fproveedor = new F_Proveedores();
            Fproveedor.MdiParent = this;
            Fproveedor.Show();
        }

        private void catalogoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CatProveedores FCatProveedores = new F_CatProveedores();
            FCatProveedores.MdiParent = this;
            FCatProveedores.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            F_CatClientes FCatClientes = new F_CatClientes();
            FCatClientes.MdiParent = this;
            FCatClientes.Show();
        }

     
    }
        
}
