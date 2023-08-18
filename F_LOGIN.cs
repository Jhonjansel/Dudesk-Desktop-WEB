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
    public partial class F_LOGIN : Fbase
    {
        E_USUARIO objEntidad = new E_USUARIO();
        N_USUARIO objNegocio = new N_USUARIO();
        public F_LOGIN()
        {
            InitializeComponent();
        }

        private void F_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataSet DS = new DataSet();
                objEntidad.Usuario = tb_user.Text.Trim();
                objEntidad.Clave = tb_clave.Text.Trim();
                DS = objNegocio.ConsultandoUsuario(objEntidad);

                string cuenta = DS.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                string clave = DS.Tables[0].Rows[0]["Clave"].ToString().Trim();

                if (cuenta == tb_user.Text && clave == tb_clave.Text)
                {
                    F_MPrincipal menu = new F_MPrincipal();
                    this.Hide();
                    menu.Show();
                    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

        }
   
    }
}
