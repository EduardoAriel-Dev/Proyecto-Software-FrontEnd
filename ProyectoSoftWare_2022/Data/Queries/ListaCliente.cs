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
        public Cliente ListaCliente_Id(int _ClienteId)
        {
            using (var Contexto = new MyDbContext())
            {
                return Contexto.clientes.Where(X => X.ClienteId == _ClienteId).FirstOrDefault();
            }
        }
    }
}
