using capaEntidad;
using capaDatos;
using System.Data;

namespace capaNegocio
{
    public class cnProductos
    {
        cdProductos cdProductos = new cdProductos();
        public bool validarDatos(ceProductos productos)
        {
            bool validar = true;   

            if (productos.descripcion == string.Empty)
            {
                validar = false;
                MessageBox.Show("La descripción es obligatorio");
            }
            if (productos.categoria == string.Empty)
            {
                validar = false;
                MessageBox.Show("La categoría es obligatorio");
            }
            /*
            if (productos.foto == null)
            {
                validar = false;
                MessageBox.Show("La Foto es obligatorio");
            }
            */
            if (productos.precio == 0)
            {
                validar = false;
                MessageBox.Show("La precio es obligatorio");
            }

            return validar;
        }

        public void PruebaMysql()
        {
            cdProductos.PruebaConexion();
        }

        public void CrearProducto(ceProductos ceProductos)
        {
            cdProductos.Crear(ceProductos);
        }

        public void EditarProducto(ceProductos ceProductos)
        {
            cdProductos.Editar(ceProductos);
        }

        public void EliminarProducto(ceProductos ceProductos)
        {
            cdProductos.Eliminar(ceProductos);
        }

        public DataSet ListarDatos() {
            return cdProductos.Listar();
        }

        public DataSet BuscarDatos(string buscar)
        {
            return cdProductos.Buscar(buscar);
        }

    }
}