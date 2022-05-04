using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Data.Queries
{
    class ListaEstado
    {
        public List<EstadoDeAlquileres> Listado_Estado()
        {
            using (var Contexto = new MyDbContext())
            {
                var ListEstado = (List<EstadoDeAlquileres>)Contexto.estadoDeAlquileres.Select(X => new { X.Descripcion, X.EstadoId });
                return ListEstado;
            }
        }

        public EstadoDeAlquileres Estado_Idx(string _Descripcion)
        {
            using (var Contexto = new MyDbContext())
            {
                return Contexto.estadoDeAlquileres.Where(X => X.Descripcion == _Descripcion).FirstOrDefault();
            }
        }
        public EstadoDeAlquileres Estado_Id(int _estadoId)
        {
            using (var Contexto = new MyDbContext())
            {
                return Contexto.estadoDeAlquileres.Where(X => X.EstadoId == _estadoId).FirstOrDefault();
            }
        }
    }
}
