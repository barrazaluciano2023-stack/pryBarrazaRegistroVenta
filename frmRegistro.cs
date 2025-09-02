using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace pryBarrazaRegistroVenta
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        //CREO VARIABLES
        DateTime vFecha = DateTime.Now;
        string vProducto = "";
        int vCantidad = 0;
        int vPrecio = 0;

        private void Principal_Load(object sender, EventArgs e)
        {
            //AGREGO ELEMENTOS A COMBO BOX
            cmbProducto.Items.Add("Gabinete");
            cmbProducto.Items.Add("CPU");
            cmbProducto.Items.Add("RAM");
        }

        private void txtProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.Text == "")
            {
                txtCantidad.Enabled = false;
            }
            else
            {
                txtCantidad.Enabled = true;
            }
        }




        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtPrecio.Enabled = false;
            }
            else
            {
                txtPrecio.Enabled = true;
            }

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //ASIGNO VALORES A VARIABLE
            vFecha = dtpFecha.Value;
            vProducto = cmbProducto.Text;
            vCantidad = Convert.ToInt32(txtCantidad.Text);
            vPrecio = Convert.ToInt32(txtPrecio.Text);


            //MostrarREsultados
            lblRegistro.Text =
                vFecha + " " + vProducto + " " +
                vCantidad + " " + vPrecio;
            limpiarControles();
        }
        private void limpiarControles()
        {
            dtpFecha.Value = DateTime.Now;
            cmbProducto.SelectedIndex = -1;
            txtCantidad.Text = "";
            txtPrecio.Text = "";

            cmbProducto.Focus();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
