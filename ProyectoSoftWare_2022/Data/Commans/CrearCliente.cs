using ProyectoSoftWare_2022.Application.ControllerCliente;
using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Data.Commans
{
    class CrearCliente
    {
        public bool _CrearCliente(string _nombre, string _apellido, string _dni, string _email)
        {

            ValidarCliente Validar = new ValidarCliente();
            Cliente cliente = new Cliente();

            
            if ((Validar.Valido(_nombre, _apellido, _dni, _email)))
            {
                cliente.Nombre = _nombre;
                cliente.Apellido = _apellido;
                cliente.DNI = _dni;
                cliente.Email = _email;
                using (var db = new MyDbContext())
                {
                    db.clientes.Add(cliente);
                    db.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
