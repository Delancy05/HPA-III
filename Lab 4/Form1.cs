
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        private string conexionString = "server=127.0.0.1; port=3306; database=productosdb; uid=root; pwd=Shupy2006;";

        // 2. Declarar los demás campos
        private List<(TextBox txt, IValidadorCampo validador)> camposValidar;
        private bool todoOk;
        private DataTable productosTable; // guardamos la tabla cargada para poder filtrarla sin re-consultar la BD


        public Form1()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
            dgvProductos.AllowUserToAddRows = false; // se agrega con el botón "Agregar", no escribiendo en la tabla
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa la lista de validación en el campo de clase
            camposValidar = new List<(TextBox, IValidadorCampo)>();
            todoOk = true;

            // Sin esta línea el grid se queda vacío al abrir el formulario
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = "SELECT id, nombre, precio, cantidad, imagen FROM productos";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    // Convertimos los bytes del BLOB a Image en una columna aparte del DataTable,
                    // así el grid recibe directamente objetos Image (no bytes) y no falla al formatear
                    dt.Columns.Add("imagenObj", typeof(Image));
                    foreach (DataRow fila in dt.Rows)
                    {
                        byte[] bytes = fila["imagen"] as byte[];
                        fila["imagenObj"] = (object)BytesAImagen(bytes) ?? DBNull.Value;
                    }

                    // Usa las columnas que ya creamos en el diseñador (Column1..Column5)
                    // en vez de dejar que se generen columnas nuevas automáticamente
                    dgvProductos.AutoGenerateColumns = false;
                    dgvProductos.RowTemplate.Height = 80; // para que la miniatura se vea bien
                    Column1.DataPropertyName = "id";
                    Column2.DataPropertyName = "nombre";
                    Column3.DataPropertyName = "precio";
                    Column4.DataPropertyName = "cantidad";
                    Column5.DataPropertyName = "imagenObj";

                    dgvProductos.DataSource = dt;
                    productosTable = dt;

                    // Por si RowTemplate.Height no se aplica retroactivamente, forzamos cada fila
                    foreach (DataGridViewRow fila in dgvProductos.Rows)
                    {
                        fila.Height = 80;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        // Método de validación masiva usando la interfaz
        private bool datosCorrectos()
        {
            camposValidar.Clear();

            // Asociamos cada TextBox con su respectiva regla de validación
            camposValidar.Add((txtNombre, new ValidatorTexto()));
            camposValidar.Add((txtPrecio, new ValidatorDecimal()));
            camposValidar.Add((txtCantidad, new ValidatorEntero()));

            todoOk = true;

            foreach (var item in camposValidar)
            {
                if (!item.validador.EsValido(item.txt.Text))
                {
                    errorProvider1.SetError(item.txt, item.validador.MensajeError);
                    todoOk = false;
                    break;
                }
                else
                {
                    errorProvider1.SetError(item.txt, string.Empty); // Limpia el error si está bien
                }
            }

            return todoOk;
        }

        private void pictureBoxPrincipal_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Selecciona una imagen del producto";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Leemos a memoria en vez de Image.FromFile() para no dejar el archivo bloqueado
                        byte[] bytes = File.ReadAllBytes(ofd.FileName);
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            pictureBoxPrincipal.Image = Image.FromStream(ms);
                        }
                        pictureBoxPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show(
                            "Ese formato de imagen no es compatible (por ejemplo, .webp no funciona). " +
                            "Usa una imagen .jpg, .png, .bmp o .gif.",
                            "Formato no compatible");
                    }
                }
            }
        }

        // Convierte los bytes guardados en la BD de vuelta a un Image para mostrarlos
        private Image BytesAImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                txtFolio.Text = Convert.ToString(fila.Cells["Column1"].Value);
                txtNombre.Text = Convert.ToString(fila.Cells["Column2"].Value);
                txtPrecio.Text = Convert.ToDecimal(fila.Cells["Column3"].Value).ToString();
                txtCantidad.Text = Convert.ToInt32(fila.Cells["Column4"].Value).ToString();

                // Precarga la imagen existente: si no seleccionan una nueva, se conserva al modificar
                pictureBoxPrincipal.Image = fila.Cells["Column5"].Value as Image;
                pictureBoxPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
            }
        }

        // Filtra el grid por nombre según lo escrito en txtBúsqueda
        private void BuscarProductos()
        {
            if (productosTable == null) return;

            string texto = txtBúsqueda.Text.Trim().Replace("'", "''"); // evita romper el filtro si escriben comillas

            productosTable.DefaultView.RowFilter = string.IsNullOrEmpty(texto)
                ? string.Empty
                : $"nombre LIKE '%{texto}%'";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void txtBúsqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita el "ding" de Windows al presionar Enter
                BuscarProductos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtFolio.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            pictureBoxPrincipal.Image = null;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            dgvProductos.ClearSelection();

            // Limpiar errores visuales del ErrorProvider
            errorProvider1.Clear();
        }

        // Convierte la imagen del PictureBox a bytes para guardarla en la columna BLOB
        private byte[] ImagenABytes(Image imagen)
        {
            if (imagen == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos antes de insertar en la BD
            if (!datosCorrectos())
            {
                return;
            }

            if (pictureBoxPrincipal.Image == null)
            {
                MessageBox.Show("Debes seleccionar una imagen para el producto.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = "INSERT INTO productos (nombre, precio, cantidad, imagen) VALUES (@nombre, @precio, @cantidad, @imagen)";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                        comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));
                        comando.Parameters.AddWithValue("@imagen", (object)ImagenABytes(pictureBoxPrincipal.Image) ?? DBNull.Value);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Producto agregado exitosamente!");
                CargarProductos();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFolio.Text))
            {
                MessageBox.Show("Selecciona un producto de la tabla para modificar.");
                return;
            }

            if (!datosCorrectos())
            {
                return;
            }

            if (pictureBoxPrincipal.Image == null)
            {
                MessageBox.Show("Debes seleccionar una imagen para el producto.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = "UPDATE productos SET nombre = @nombre, precio = @precio, cantidad = @cantidad, imagen = @imagen WHERE id = @id";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtFolio.Text));
                        comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                        comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));
                        comando.Parameters.AddWithValue("@imagen", (object)ImagenABytes(pictureBoxPrincipal.Image) ?? DBNull.Value);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Producto modificado exitosamente!");
                CargarProductos();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFolio.Text))
            {
                MessageBox.Show("Selecciona un producto de la tabla para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Seguro que deseas eliminar el producto \"{txtNombre.Text}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = "DELETE FROM productos WHERE id = @id";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtFolio.Text));
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Producto eliminado exitosamente!");
                CargarProductos();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

