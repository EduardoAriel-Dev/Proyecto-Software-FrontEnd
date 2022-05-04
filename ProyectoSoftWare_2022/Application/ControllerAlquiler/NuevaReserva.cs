using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftWare_2022.Data.Models;
using ProyectoSoftWare_2022.Presetation;
using ProyectoSoftWare_2022.Application.ControllerCliente;
using ProyectoSoftWare_2022.Application.ControllerLibro;
using ProyectoSoftWare_2022.Data.Queries;
using ProyectoSoftWare_2022.Data.Commans;

namespace ProyectoSoftWare_2022.Application.ControllerAlquiler
{
    class NuevaReserva
    {
        public void Nuevo_Reserva()
        {
            Console.Clear();
            Menu _menu = new Menu();
            CrearReserva crearReserva = new CrearReserva();


            //Verificar Datos
            ValidarDNI validarDNI = new ValidarDNI();
            ValidarISBN validarISBN = new ValidarISBN();
            //--------

            //Creo las clases para los IDs
            Cliente cliente_Reserva = new Cliente();
            Libros libros_Reserva = new Libros();
            EstadoDeAlquileres estado_Reservado = new EstadoDeAlquileres();
            //--------

            //Lista de los Objetos
            QueriesLibrosStock ConsultaLibro = new QueriesLibrosStock();
            List<Libros> ListLibro = ConsultaLibro.ListaLibros();
            ListaEstado listaEstado = new ListaEstado();
            //-------

            DateTime DiaHoy_Reservado = DateTime.Now;
            bool Reservado = false;
            while (!Reservado)
            {
                try
                {
                    Console.WriteLine("Ingrese el DNI del Cliente");
                    int _dni_Valido = int.Parse(Console.ReadLine());
                    string _dni = _dni_Valido.ToString();
                    if (!validarDNI._dniValido(_dni))
                    {
                        cliente_Reserva = new ListaCliente().Cliente_Idx(_dni);

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
                        libros_Reserva = new QueriesLibrosStock().Libro_Idx(_ISBN);
                    }
                    else
                    {
                        Console.WriteLine("El Libro no Existe: ");
                        Console.ReadKey();
                        _menu._MENU();
                    }

                    estado_Reservado = listaEstado.Estado_Idx("Reservado");                                          //Dia Alquiler, Dia Devolucion
                    Alquileres alquiler = crearReserva._CrearReserva(cliente_Reserva, estado_Reservado, libros_Reserva, DiaHoy_Reservado);
                    if (alquiler != null)
                    {                    
                        Console.WriteLine("Reservado Realizado con exito");
                    }
                    Reservado = true;
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
