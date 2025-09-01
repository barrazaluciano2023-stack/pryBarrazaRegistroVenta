using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaRegistroVenta
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }






        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            //if (dtpFecha.Value != null)
            //{
            //    txtProducto.Enabled = true;
            //}
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                txtCantidad.Enabled = true;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                txtPrecio.Enabled = true;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
