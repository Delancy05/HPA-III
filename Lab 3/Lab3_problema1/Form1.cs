using System;
using System.Collections;
using System.Windows.Forms;

namespace EjemploGrid
{
    public partial class Form1 : Form
    {
        // ArrayList para almacenar los objetos Persona
        // ArrayList pertenece al espacio de nombres System.Collections

        ArrayList listaPersonas = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona miColaborador1 = new Persona();

            miColaborador1.Id = 1;
            miColaborador1.Nombres = "Elena Carolina";
            miColaborador1.Apellidos = "González Rodríguez";
            miColaborador1.Correo = "elena.gonzalez@ejemplo.com";
            miColaborador1.FechaNacimiento = new DateTime(1998, 5, 15);
            listaPersonas.Add(miColaborador1);
            dgvDatos.DataSource = listaPersonas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text == "")
            {
                errorProvider1.SetError(txtIdEmpleado, "Ingrese un ID");
                txtIdEmpleado.Focus();
                return; // <-- Interrumpe y finaliza la ejecución del método actual
            }
            else
            {
                errorProvider1.SetError(txtIdEmpleado, "");
            }

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese los nombres del Colaborador");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "Ingrese los apellidos del Colaborador");
                txtApellido.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellido, "");
            }

            if (Utilidades.EsCorreoValido(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Ingrese un correo válido");
                txtEmail.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            decimal salario1;
            if (!decimal.TryParse(txtSalario.Text, out salario1))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }

            Persona colaborador1 = new Persona();
            colaborador1.Id = int.Parse(txtIdEmpleado.Text);
            colaborador1.Nombres = txtNombre.Text;
            colaborador1.Apellidos = txtApellido.Text;
            colaborador1.Correo = txtEmail.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacimiento = dtpFechaNacimiento.Value;
            listaPersonas.Add(colaborador1);
            dgvDatos.DataSource = null; // Limpiar el DataSource antes de asignar la nueva lista
            dgvDatos.DataSource = listaPersonas;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdEmpleado.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtSalario.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            errorProvider1.Clear();
            txtIdEmpleado.Focus();
        }
    }
}
