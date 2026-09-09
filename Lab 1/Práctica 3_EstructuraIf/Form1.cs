using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pract_3___EstructuraIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnSuma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSuma.Checked)
            {
                lblSigno.Text = "+";
            }
        }

        private void rbtnResta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnResta.Checked)
            {
                lblSigno.Text = "-";
            }
        }

        private void rbtnMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMultiplicacion.Checked)
            {
                lblSigno.Text = "*";
            }
        }

        private void rbtnDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDivision.Checked)
            {
                lblSigno.Text = "/";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double resultado = 0;

                if (rbtnSuma.Checked)
                {
                    resultado = num1 + num2;
                }
                else if (rbtnResta.Checked)
                {
                    resultado = num1 - num2;
                }
                else if (rbtnMultiplicacion.Checked)
                {
                    resultado = num1 * num2;
                }
                else if (rbtnDivision.Checked)
                {
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre cero.");
                        return;
                    }
                }

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos en las casillas.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();

            lblSigno.Text = "+";

            rbtnSuma.Checked = false;
            rbtnResta.Checked = false;
            rbtnMultiplicacion.Checked = false;
            rbtnDivision.Checked = false;

            txtNum1.Focus();
        }
    }
}
