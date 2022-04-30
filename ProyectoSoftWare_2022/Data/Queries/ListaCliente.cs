using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Data.Queries
{
    class ListaCliente
    {
        public List<Cliente> Listado_Cliente()
        {
            using (var Contexto = new MyDbContext())
            {
                var ListClient = (List<Cliente>)Contexto.clientes.Select(X => new { X.Nombre, X.Apellido, X.ClienteId });
                return ListClient;
            }
        }
        public Cliente Cliente_Idx(string _dni)
        {
            using (var Contexto = new MyDbContext())
            {
                return Contexto.clientes.Where(X => X.DNI == _dni).FirstOrDefault();
            }
        }
    }
}
