using capaEntidad;
using MySql.Data.MySqlClient;
using System.Data;

namespace capaDatos
{
    public class cdProductos
    {
        conexion cadena = new conexion();

        public DataTable cargaComboBox()
        
            {
                DataTable dataTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(cadena.validarDatos()))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT idcategoria, categoriacol FROM categoria ORDER BY categoriacol ASC";
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier excepción que pueda ocurrir al acceder a la base de datos
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                return dataTable;
            }

            public void PruebaConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion" + ex.Message);
                return;
            }
            conexion.Close();
            MessageBox.Show("Conexion exitosa");
        }

        public void Crear(ceProductos ceProductos)
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            conexion.Open();
            
            string Query = "INSERT INTO `productos` (`precio`, `descripcion`, `foto`, `categoria`) VALUES ('" + ceProductos.precio + "','" + ceProductos.descripcion + "','" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(ceProductos.foto) + "','" + ceProductos.categoria + "');";
                          
            MySqlCommand mySqlCommand = new MySqlCommand(Query, conexion);

            mySqlCommand.ExecuteNonQuery();  // inserta pero no devuelve ningun valor.
            conexion.Close();
            MessageBox.Show("Producto Creado..");
        }

        public void Editar(ceProductos ceProductos)
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            conexion.Open();

            string Query = "UPDATE productos SET `precio`= '" + ceProductos.precio + "', `descripcion`= '" + ceProductos.descripcion + "', `foto`= '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(ceProductos.foto) + "', `categoria`= '" + ceProductos.categoria + "' WHERE `id`='" + ceProductos.codigo + "';";

            MySqlCommand mySqlCommand = new MySqlCommand(Query, conexion);

            mySqlCommand.ExecuteNonQuery();  // inserta pero no devuelve ningun valor.
            conexion.Close();
            MessageBox.Show("Producto Actualizado..");
        }

        public void Eliminar(ceProductos ceProductos)
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            conexion.Open();

            string Query = "DELETE FROM productos WHERE `id`='" + ceProductos.codigo + "';";

            MySqlCommand mySqlCommand = new MySqlCommand(Query, conexion);

            mySqlCommand.ExecuteNonQuery();  // inserta pero no devuelve ningun valor.
            conexion.Close();
            MessageBox.Show("Producto Eliminado..");
        }

        public DataSet Listar()
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            conexion.Open();

            string Query = "select * from productos ORDER BY descripcion ASC;";

            MySqlDataAdapter adaptador;
            DataSet dataSet = new DataSet();
            adaptador= new MySqlDataAdapter(Query, conexion);
            adaptador.Fill(dataSet, "tbl");
            return dataSet;
        }

        public DataSet Buscar(string buscar)
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            conexion.Open();

            string Query = "select id,precio,descripcion,foto,categoria from productos where productos.precio LIKE '%" + buscar + "%'|| productos.descripcion LIKE '%" + buscar + "%' || productos.categoria LIKE '%" + buscar + "%' ORDER BY descripcion ASC;";

            MySqlDataAdapter adaptador;
            DataSet dataSet = new DataSet();
            adaptador = new MySqlDataAdapter(Query, conexion);
            adaptador.Fill(dataSet, "tbl");
            return dataSet;
        }
    }
}