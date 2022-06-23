using System;
using System.Collections.Generic;
using ProyectoSoftWare_2022.Presetation;
using ProyectoSoftWare_2022.Data.Models;
using ProyectoSoftWare_2022.Data.Queries;

namespace ProyectoSoftWare_2022.Application.ControllerLibro
{
    internal class LibroEnStock
    {
        public void ListaLibro()
        {
            Console.Clear();
            QueriesLibrosStock lista = new QueriesLibrosStock();
            List<Libros> l = lista.ListaLibros();
            Menu _menu = new Menu();

            Console.WriteLine("Lista de los Libros con Stock Disponible");
            foreach (Libros X in l)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("ISBN: " + X.ISBN);
                Console.WriteLine("Titulo: " + X.Titulo);
                Console.WriteLine("Autor" + X.Autor);
                Console.WriteLine("Editorial" + X.Editorial);
                Console.WriteLine("Edicion" + X.Edicion);
                Console.WriteLine("Imagen" + X.Imagen);
                Console.WriteLine("--------------------------------------------------\n\n");

            }
            Console.ReadKey();
            _menu._MENU();
        }
    }
}
