using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceClientes
    {
        public int id { get; set; }
        public int idLocalidad { get; set; }
        public int descuento { get; set; }
        public int telefono { get; set; }
        public string? cuil { get; set; }
        public string? nombre { get; set; }
        public string? razonSocial { get; set; }
        public string? domicilio { get; set; }
        public string? email { get; set; }
    }
}
