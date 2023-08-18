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
    public partial class F_Proveedores : Fbase{
        readonly ProveedorEntidad  PROentidad = new ProveedorEntidad();
        readonly ProveedorNegocio PROnegocio = new ProveedorNegocio();
        public bool update = false;

        public F_Proveedores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                try
                {
                    PROentidad.Nombre = tb_Nombre.Text;
                    PROentidad.Identificacion = tb_Identificacion.Text;
                    PROentidad.Direccion = tb_Direccion.Text;
                    PROentidad.Telefono = tb_Telefono.Text;
                    PROentidad.Correo = tb_Correo.Text;
                    PROentidad.FechaRegistro = dt_Registro.Value;

                    PROnegocio.InsertandoProveedor(PROentidad);
                    MessageBox.Show("Proveedor Guardado");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede guardar el Proveedor" + ex.Message);

                }
            }
            if (update == true)
            {
                try
                {
                    PROentidad.IdProveedor = Convert.ToInt32(lb_id.Text);
                    PROentidad.Nombre = tb_Nombre.Text;
                    PROentidad.Identificacion = tb_Identificacion.Text;
                    PROentidad.Direccion = tb_Direccion.Text;
                    PROentidad.Telefono = tb_Telefono.Text;
                    PROentidad.Correo = tb_Correo.Text;
                    PROentidad.FechaRegistro = dt_Registro.Value;
                    PROnegocio.EditandoProveedor(PROentidad);
                    MessageBox.Show("Proveedor Editado");

                    Close();
                    update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el Proveedor" + ex.Message);

                }
            }

        }
    }
}
