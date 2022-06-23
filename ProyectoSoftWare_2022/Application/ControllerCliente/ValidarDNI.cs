using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Application.ControllerCliente
{
    class ValidarDNI
    {
        public bool _dniValido(string _dni)
        {
            using (var contexto = new MyDbContext())
            {
                var ListClient = contexto.clientes.Where(X => X.DNI == _dni).ToList();

                if (ListClient.Count == 0)
                {
                    return true;
                }
                    return false;
            }
        }
    }
}
