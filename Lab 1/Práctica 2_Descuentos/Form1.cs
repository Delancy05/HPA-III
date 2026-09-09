using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica1_Descuento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDescuentodolares_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorVenta, descuentoPorcentaje;
            decimal descuentoVenta;
            decimal ventaFinal;

            if (decimal.TryParse(txtValorVenta.Text, out valorVenta))
            {
                if (valorVenta >= 500)
                {
                    descuentoPorcentaje = 0.30m;
                }
                else if (valorVenta >= 300 && valorVenta <= 499)
                {
                    descuentoPorcentaje = 0.20m;
                }
                else if (valorVenta >= 100 && valorVenta <= 299)
                {
                    descuentoPorcentaje = 0.10m;
                }
                else
                {
                    descuentoPorcentaje = 0m;
                }

                descuentoVenta = valorVenta * descuentoPorcentaje;
                ventaFinal = valorVenta - descuentoVenta;

                txtVentaFinal.Text = (valorVenta - descuentoVenta).ToString();
                txtDescuentoPorcentaje.Text = (descuentoPorcentaje * 100).ToString() + "%";
                txtDescuentoDolares.Text = descuentoVenta.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorVenta.Text = "";
            txtDescuentoDolares.Text = "";
            txtDescuentoPorcentaje.Text = "";
            txtVentaFinal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando", "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
