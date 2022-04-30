using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftWare_2022.Data.Models
{
    class EstadoDeAlquileres
    {
        public int EstadoId { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Alquileres> Alquileres_EA { get; set; }
    }
}
