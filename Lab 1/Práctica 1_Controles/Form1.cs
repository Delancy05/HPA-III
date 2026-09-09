using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            if (txtDia.Text == "" || txtMes.Text == "" || txtAnio.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblFecha.Text = "La fecha es: " + txtDia.Text + "-" + txtMes.Text + "-" + txtAnio.Text;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará la ventana", "Info",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Cerrando", "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
    
}
