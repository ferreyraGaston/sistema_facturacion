using capaDatos;
using capaEntidad;
using capaNegocio;
using MySql.Data.MySqlClient;
using System.Data;

namespace capaPresentacion
{
    public partial class frProductos : Form
    {
        cnProductos cnProductos = new cnProductos();
        public frProductos()
        {
            InitializeComponent();
            cargarComboBox();
            txtPrecio.Minimum = decimal.MinValue;  // Establece el valor mínimo como el valor mínimo posible para un decimal
            txtPrecio.Maximum = decimal.MaxValue;  // Establece el valor máximo como el valor máximo posible para un decimal
            txtPrecio.Focus();
        }

        private void cargarComboBox()
        {
            // Crear una instancia de la capa de datos
            cdProductos categoriaData = new cdProductos();

            // Llamar al método para obtener las categorías desde la capa de datos
            DataTable categoriasTable = categoriaData.cargaComboBox();

            // Asignar el DataTable como fuente de datos para el ComboBox
            txtCategoria.DataSource = categoriasTable;
            txtCategoria.DisplayMember = "categoriacol"; // El campo que se mostrará en el ComboBox
            txtCategoria.ValueMember = "idcategoria"; // El valor asociado a cada elemento

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            LimpiarFormulario();

        }


        private void lnkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdFoto.FileName = string.Empty; // La cadena está vacía

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado por el usuario
                string filePath = ofdFoto.FileName;

                // Obtener la ruta del directorio donde está instalado el repositorio
                string repoDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Crear la ruta completa para la carpeta "img" en el directorio del repositorio
                string imgDirectory = Path.Combine(repoDirectory, "img");

                // Si la carpeta "img" no existe, créala
                if (!Directory.Exists(imgDirectory))
                {
                    Directory.CreateDirectory(imgDirectory);
                }

                // Obtener el nombre de archivo sin la ruta completa
                string fileName = Path.GetFileName(filePath);

                // Construir la ruta completa para guardar la imagen en la carpeta "img"
                string destinationPath = Path.Combine(imgDirectory, fileName);

                // Copiar el archivo seleccionado a la carpeta "img"
                File.Copy(filePath, destinationPath, true);

                // Cargar la imagen en el control PictureBox
                picFoto.ImageLocation = destinationPath;
            }
            ofdFoto.FileName = string.Empty; // La cadena está vacía
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool validar;
            ceProductos productos = new ceProductos();
            productos.categoria = txtCategoria.Text.ToString();
            productos.descripcion = txtDescripcion.Text;
            //MessageBox.Show("ES " + decimal.Parse(txtPrecio.Text));
            productos.precio = decimal.Parse(txtPrecio.Text);
            productos.codigo = (int)txtCodigo.Value;
            productos.foto = picFoto.ImageLocation;

            validar = cnProductos.validarDatos(productos);

            if (validar == false)
            {
                return;
            }

            if (productos.codigo == 0)
            {
                cnProductos.CrearProducto(productos);
            }
            else
            {
                cnProductos.EditarProducto(productos);
            }
            LimpiarFormulario();
            cargarDAtos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //cnProductos.PruebaMysql();  // solo para hacer prueba de conexion
            ceProductos productos = new ceProductos();
            productos.codigo = (int)txtCodigo.Value;

            if (txtCodigo.Value == 0)
            {
                return;
            }
            if (MessageBox.Show("¿ Estas seguro que deseas eliminar el producto ?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnProductos.EliminarProducto(productos);

            }
            LimpiarFormulario();
            cargarDAtos();
        }

        private void frClientes_Load(object sender, EventArgs e)
        {
            cargarDAtos();
        }

        private void cargarDAtos()
        {
            gridDatos.DataSource = cnProductos.ListarDatos().Tables["tbl"];
        }

        private void LimpiarFormulario()
        {
            txtPrecio.Value = 0;
            txtCodigo.Value = 0;
            txtCategoria.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            picFoto.Image = null;
            txtPrecio.Focus();
        }

        private void gridDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Value = (int)gridDatos.CurrentRow.Cells["id"].Value;
            txtCategoria.Text = gridDatos.CurrentRow.Cells["categoria"].Value.ToString();
            txtPrecio.Value = decimal.Parse(gridDatos.CurrentRow.Cells["precio"].Value.ToString());
            txtDescripcion.Text = gridDatos.CurrentRow.Cells["descripcion"].Value.ToString();
            picFoto.Load(gridDatos.CurrentRow.Cells["foto"].Value.ToString());

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                gridDatos.Columns.Clear();
                CargarTablaLibroBuscar(txtBuscar.Text);
                txtBuscar.Text = "";
            }
            else
            {
                cargarDAtos();
            }

        }

        private void CargarTablaLibroBuscar(string buscar)
        {
            gridDatos.DataSource = cnProductos.BuscarDatos(buscar).Tables["tbl"];
        }

    }
}