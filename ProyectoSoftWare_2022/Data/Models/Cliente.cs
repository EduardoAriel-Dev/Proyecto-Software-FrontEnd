using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftWare_2022.Data.Models
{
    class Cliente
    {
        public int ClienteId { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public ICollection<Alquileres> Alquiler_C { get; set; }

    }
}
