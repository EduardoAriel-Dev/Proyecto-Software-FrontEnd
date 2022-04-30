using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftWare_2022.Application.ControllerCliente;
using ProyectoSoftWare_2022.Application.ControllerLibro;
using ProyectoSoftWare_2022.Application.ControllerAlquiler;

namespace ProyectoSoftWare_2022.Presetation
{
    class Menu
    {
         public void _MENU()
         {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("|                                               Municipalidad 9 de Julio                                           |");
                Console.WriteLine("|                                                    Menu Principal                                                |");
                Console.WriteLine("|                                                                                                                  |");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("\n");
                Console.WriteLine("1)Crear Cliente.");
                Console.WriteLine("2)Crear Alquiler.");
                Console.WriteLine("3)Crear Reserva.");
                Console.WriteLine("4)Enlistar Reservas de Libros.");
                Console.WriteLine("5)Libros que tenemos en Stock.");
                Console.WriteLine("6)Salir de la Aplicacion");

                Console.Write("\n\nSelecciona una Opcion.\n");
                try
                {
                    int Valor = int.Parse(Console.ReadLine());
                    switch (Valor)
                    {
                        case 1:
                            NuevoCliente nuevoCliente = new NuevoCliente();
                            nuevoCliente._NuevoCliente();
                            break;
                        case 2:
                            NuevoAlquiler nuevoAlquiler = new NuevoAlquiler();
                            nuevoAlquiler.Nuevo_Alquiler();
                            break;
                        case 3:                            
                            break;
                        case 4:
                            break;
                        case 5:
                            LibroEnStock libro_stock = new LibroEnStock();
                            libro_stock.ListaLibro();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo del programa");
                            Thread.Sleep(5000);
                            break;
                        default:
                            throw new Exception();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("El dato Ingresado es erroneo");
                    Thread.Sleep(5000);
                    Console.Clear();
                    _MENU();
                }
            }
        }
    }
