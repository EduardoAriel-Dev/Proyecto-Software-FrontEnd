using ProyectoSoftWare_2022.Data.Queries;
using ProyectoSoftWare_2022.Presetation;

namespace ProyectoSoftWare_2022.Application.ControllerLibro
{
    class ListaLibrosReservados
    {
        Menu _menu = new Menu(); 
        
        public void ListLibroReservado() {
            var listaAlquileres = new ListaAlquileres().listaAlquileres();
            
            foreach (var Alquiler in listaAlquileres)
            {
                var listaCliente = new ListaCliente().ListaCliente_Id(Alquiler.ClienteId);
                var listaLibro = new QueriesLibrosStock().Libro_Idx(Alquiler.IsbnId);
                var listaEstado = new ListaEstado().Estado_Id(Alquiler.EstadoDeAlquileresId);
                if ("Reservado"==listaEstado.Descripcion)
                {
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("Nombre del Cliente: " + listaCliente.Nombre + ", Apellido " + listaCliente.Apellido);
                    Console.WriteLine("Nombre Libro: " + listaLibro.Titulo);
                    Console.WriteLine("ISBN: " + listaLibro.ISBN);
                    Console.WriteLine("Autor: " + listaLibro.Autor);
                    Console.WriteLine("Editorial: " + listaLibro.Editorial);
                    Console.WriteLine("Edicion: " + listaLibro.Edicion);
                    Console.WriteLine("Imagen: " + listaLibro.Imagen);
                    Console.WriteLine("--------------------------------------------------------------------");
                }
            }
            Console.ReadKey();
            _menu._MENU();
        }
    }
}
