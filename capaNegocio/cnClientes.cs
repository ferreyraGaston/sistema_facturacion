using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace capaNegocio
{
    public class cnClientes
    {
        cdClientes cdClientes = new cdClientes();
        public bool validarDatos(ceClientes clientes)
        {
            bool validar = true;

            if (clientes.nombre == string.Empty)
            {
                validar = false;
                MessageBox.Show("El nombre es obligatorio");
            }
            if (clientes.domicilio == string.Empty)
            {
                validar = false;
                MessageBox.Show("El domicilio es obligatorio");
            }
            
            if (clientes.email == string.Empty)
            {
                validar = false;
                MessageBox.Show("El email es obligatorio");
            }
           
            if (clientes.cuil == string.Empty)
            {
                validar = false;
                MessageBox.Show("El cuil es obligatorio");
            }

            return validar;
        }


        public void CrearCliente(ceClientes ceClientes)
        {
            cdClientes.Crear(ceClientes);
        }

        public void EditarCliente(ceClientes ceClientes)
        {
            cdClientes.Editar(ceClientes);
        }

        public void EliminarCliente(ceClientes ceClientes)
        {
            cdClientes.Eliminar(ceClientes);
        }

        public DataSet ListarDatos()
        {
            return cdClientes.Listar();
        }

        public DataSet BuscarDatos(string buscar)
        {
            return cdClientes.Buscar(buscar);
        }


    }
}
