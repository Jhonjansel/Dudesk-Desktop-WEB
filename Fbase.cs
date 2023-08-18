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
    public partial class Fbase : Form
    {
        public Fbase()
        {
            InitializeComponent();
        }

        private void Fbase_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }
        private void FBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {
                BtnCancelar.PerformClick();
            }
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {
                this.Close();
            }
        }
    }
}
