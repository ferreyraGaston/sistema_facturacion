using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace capaDatos
{
    public class cdClientes
    {
        conexion cadena = new conexion();

        public void Crear(ceClientes ceClientes)
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            conexion.Open();

            string Query = "INSERT INTO `clientes` (`idLocalidad`, `descuento`, `telefono`, `cuil`, `nombre`, `nombreNeg`, `domicilio`, `email`) VALUES ('" + ceClientes.idLocalidad + "','" + ceClientes.descuento + "','" + ceClientes.telefono + "','" + ceClientes.cuil + "','" + ceClientes.nombre + "','" + ceClientes.razonSocial + "','" + ceClientes.domicilio + "','" + ceClientes.email + "');";

            MySqlCommand mySqlCommand = new MySqlCommand(Query, conexion);

            mySqlCommand.ExecuteNonQuery();  // inserta pero no devuelve ningun valor.
            conexion.Close();
            MessageBox.Show("Cliente Creado..");
        }

        public void Editar(ceClientes ceClientes)
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            conexion.Open();

            string Query = "UPDATE clientes SET `idLocalidad`= '" + ceClientes.idLocalidad + "', `descuento`= '" + ceClientes.descuento + "', `telefono`= '" + ceClientes.telefono + "', `cuil`= '" + ceClientes.cuil + "', `nombre`= '" + ceClientes.nombre + "', `nombreNeg`= '" + ceClientes.razonSocial + "', `domicilio`= '" + ceClientes.domicilio + "', `email`= '" + ceClientes.email + "' WHERE `id`='" + ceClientes.id + "';";

            MySqlCommand mySqlCommand = new MySqlCommand(Query, conexion);

            mySqlCommand.ExecuteNonQuery();  // inserta pero no devuelve ningun valor.
            conexion.Close();
            MessageBox.Show("Cliente Actualizado..");
        }
        public void Eliminar(ceClientes ceClientes)
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            conexion.Open();

            string Query = "DELETE FROM clientes WHERE `id`='" + ceClientes.id + "';";

            MySqlCommand mySqlCommand = new MySqlCommand(Query, conexion);

            mySqlCommand.ExecuteNonQuery();  // inserta pero no devuelve ningun valor.
            conexion.Close();
            MessageBox.Show("Cliente Eliminado..");
        }

        public DataSet Listar()
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            conexion.Open();

            string Query = "select * from clientes ORDER BY nombre ASC;";

            MySqlDataAdapter adaptador;
            DataSet dataSet = new DataSet();
            adaptador = new MySqlDataAdapter(Query, conexion);
            adaptador.Fill(dataSet, "tbl");
            return dataSet;
        }

        public DataSet Buscar(string buscar)
        {
            MySqlConnection conexion = new MySqlConnection(cadena.validarDatos());
            conexion.Open();

            string Query = "selec * from clientes where clientes.nombre LIKE '%" + buscar + "%'|| clientes.cuil LIKE '%" + buscar + "%' || clientes.nombreNeg LIKE '%" + buscar + "%' ORDER BY nombre ASC;";

            MySqlDataAdapter adaptador;
            DataSet dataSet = new DataSet();
            adaptador = new MySqlDataAdapter(Query, conexion);
            adaptador.Fill(dataSet, "tbl");
            return dataSet;
        }

    }
}
