using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductPrecio
{
    public partial class Form1 : Form
    {
        ProductPrecio.Producto ListaPrecio = new ProductPrecio.Producto();
        public Form1()
        {
            InitializeComponent();
        }

        private void btAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProducto.Text == "" || txtPrecio.Text == "")
                {
                    MessageBox.Show("Error: ");
                }
                else
                {
                    lblLista.Text = ListaPrecio.CargarLista(
                        txtProducto.Text,
                        txtPrecio.Text);

                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            lblLista.Text = ListaPrecio.Ordenar();
        }
    }
}
