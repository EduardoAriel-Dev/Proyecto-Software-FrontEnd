using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftWare_2022.Data.Models;

/*namespace ProyectoSoftWare_2022.Data.Queries
{
    class QueriesLibrosReservados
    {
        public List<Alquileres> LibroReserva()
        {
            using (var Contexto = new MyDbContext())
            {
                var ListLibroReservado = (from alquileresReservado in Contexto.alquileres
                                          join LibroReservado in Contexto.libros on
                                          alquileresReservado.IsbnId equals LibroReservado.ISBN
                                          select new
                                          {
                                              alquileresReservado.Id,
                                              LibroReservado.ISBN,
                                              LibroReservado.Titulo,
                                              LibroReservado.Autor,
                                              LibroReservado.Editorial,
                                              LibroReservado.Edicion,
                                              LibroReservado.Stock,
                                              LibroReservado.Imagen
                                          });
                return (List<Alquileres>)ListLibroReservado;
            }        
        }
    }
}*/
