using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Data.Queries
{
    class ListaAlquileres
    {
        public List<Alquileres> listaAlquileres() {
            using (var contexto = new MyDbContext()) {
                var l = contexto.alquileres.ToList();
                return l;
            }
        }
    }
}
