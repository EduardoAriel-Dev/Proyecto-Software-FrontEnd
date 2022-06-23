using ProyectoSoftWare_2022.Presetation;
using ProyectoSoftWare_2022.Data.Models;
using ProyectoSoftWare_2022.Data.Commans;

namespace ProyectoSoftWare_2022.Application.ControllerCliente
{
    class NuevoCliente
    {
        public void _NuevoCliente() {
            Console.Clear();
            Menu _M = new Menu();
            CrearCliente crearcliente = new CrearCliente();
            ValidarDNI _ValidarDNI = new ValidarDNI();

            bool Verifycarted = false;
            string DNI = "";
            string Nombre = "";
            string Apellido = "";
            string Email = "";
            List<Cliente> cliente = null;
            while (!Verifycarted)
            {
                try
                {
                    //Ingreso de los datos.
                    Console.WriteLine("Ingrese su DNI.");
                    int Verificador = int.Parse(Console.ReadLine());
                    DNI = Verificador.ToString();
                    if (_ValidarDNI._dniValido(DNI))
                    {
                        Console.WriteLine("Ingrese su Nombre.");
                        Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su Apellido.");
                        Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese su Email.");
                        Email = Console.ReadLine();
                        Verifycarted = true;
                        crearcliente._CrearCliente(Nombre, Apellido, DNI, Email);
                        Console.WriteLine("Datos Guardados");
                        Console.ReadKey();
                   }
                    else
                    {
                        Console.WriteLine("El DNI ya existe");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Datos Erroneos");
                }
            }
            Console.Clear();
            _M._MENU();
        }
    }
}
