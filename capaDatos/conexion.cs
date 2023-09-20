using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    internal class conexion
    {
        
        public string validarDatos()
        {
            string cadenaConexion = "Server=localhost;UserID=root;Database=hfDistribuidora;Password=13231414;";
            return cadenaConexion;
        }
    }
}
