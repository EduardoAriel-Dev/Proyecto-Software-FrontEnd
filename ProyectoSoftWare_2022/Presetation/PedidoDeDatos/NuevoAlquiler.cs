using ProyectoSoftWare_2022.Data.Models;
using ProyectoSoftWare_2022.Presetation;
using ProyectoSoftWare_2022.Application.ControllerCliente;
using ProyectoSoftWare_2022.Application.ControllerLibro;
using ProyectoSoftWare_2022.Data.Queries;
using ProyectoSoftWare_2022.Data.Commans;


namespace ProyectoSoftWare_2022.Application.ControllerAlquiler
{
    class NuevoAlquiler
    {
        public void Nuevo_Alquiler()
        {
            Console.Clear();
            Menu _menu = new Menu();
            CrearAlquiler crearAlquiler = new CrearAlquiler();

            //Verificar Datos
            ValidarDNI validarDNI = new ValidarDNI();
            ValidarISBN validarISBN = new ValidarISBN();
            //--------

            //Creo las clases para los IDs
            Cliente cliente_Alquiler = new Cliente();
            Libros libros_Alquiler = new Libros();
            EstadoDeAlquileres estado_Alquiler = new EstadoDeAlquileres();
            //--------

            //Lista de los Objetos
            QueriesLibrosStock ConsultaLibro = new QueriesLibrosStock();
            List<Libros> ListLibro = ConsultaLibro.ListaLibros();
            ListaEstado listaEstado = new ListaEstado();
            //-------

            DateTime DiaHoy = DateTime.Now;
            bool Alquilado = false;
            while (!Alquilado)
            {
                try
                {
                    Console.WriteLine("Ingrese el DNI del Cliente");
                    int _dni_Valido = int.Parse(Console.ReadLine());
                    string _dni = _dni_Valido.ToString();
                    if (!validarDNI._dniValido(_dni))
                    {
                        cliente_Alquiler = new ListaCliente().Cliente_Idx(_dni);

                    }
                    else
                    {
                        Console.WriteLine("El usuario no existe");
                        Console.ReadKey();
                        _menu._MENU();
                    }



                    Console.WriteLine("Lista de Libros Disponibles");
                    foreach (Libros l in ListLibro)
                    {
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine("ISBN: " + l.ISBN);
                        Console.WriteLine("Titulo: " + l.Titulo);
                        Console.WriteLine("-----------------------------------------------------------");
                    }
                    Console.WriteLine("Ingrese el ISBN del libro");
                    string _ISBN = Console.ReadLine();

                    if (!validarISBN._ISBN_Valido(_ISBN))
                    {
                        libros_Alquiler = new QueriesLibrosStock().Libro_Idx(_ISBN);
                    }

                    else
                    {
                        Console.WriteLine("El Libro no Existe: ");
                        Console.ReadKey();
                        _menu._MENU();
                    }
                    estado_Alquiler = listaEstado.Estado_Idx("Alquilado");
                    Alquileres alquiler = crearAlquiler._CrearAlquiler(cliente_Alquiler,estado_Alquiler,libros_Alquiler,DiaHoy,DiaHoy.AddDays(7));
                   
                    Alquilado = true;
                    Console.ReadKey();
                    _menu._MENU();

                }   
                catch (Exception)
                {
                    Console.WriteLine("ALGO PASO");
                    throw;
                }
            }
        }
    }
}
