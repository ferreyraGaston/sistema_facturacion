using capaDatos;
using capaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frClientes : Form
    {
        cnClientes cnClientes = new cnClientes();
        public frClientes()
        {
            InitializeComponent();
        }
        private void LimpiarFormulario()
        {
            txtTelefono.Value = 0;
            txtId.Value = 0;
            txtProvincia.Text = string.Empty;
            txtCuil.Text = string.Empty;
            picFoto.Image = null;
            txtTelefono.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //cnProductos.PruebaMysql();  // solo para hacer prueba de conexion
            ceClientes clientes = new ceClientes();
            clientes.id = (int)txtId.Value;

            if (txtId.Value == 0)
            {
                return;
            }
            if (MessageBox.Show("¿ Estas seguro que deseas eliminar el cliente ?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnClientes.EliminarCliente(clientes);

            }
            LimpiarFormulario();
            cargarDAtos();
        }
        private void cargarDAtos()
        {
            gridDatos.DataSource = cnClientes.ListarDatos().Tables["tbl"];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool validar;
            ceClientes clientes = new ceClientes();
            clientes.idLocalidad = (int)txtId.Value;
            clientes.nombre = txtNombre.Text.ToString();
            clientes.razonSocial = textRazonSocial.Text.ToString();
            clientes.cuil = txtCuil.Text.ToString();
            clientes.domicilio = txtDomicilio.ToString();
            clientes.telefono = (int)txtTelefono.Value;
            clientes.descuento = (int)txtDescuento.Value;
            validar = cnClientes.validarDatos(clientes);

            if (validar == false)
            {
                return;
            }

            if (clientes.id == 0)
            {
                cnClientes.CrearCliente(clientes);
            }
            else
            {
                cnClientes.EditarCliente(clientes);
            }
            LimpiarFormulario();
            cargarDAtos();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
