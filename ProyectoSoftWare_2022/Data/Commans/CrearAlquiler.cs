using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Data.Commans
{
    class CrearAlquiler
    {
        EstadoDeAlquileres Estado_Alquiler = new EstadoDeAlquileres();

        public Alquileres _CrearAlquiler(Cliente _cliente_Id, EstadoDeAlquileres _estado_Id, Libros _libro_idx, DateTime fecha_Alquiler, DateTime fecha_devolucion)
        {
        

            using (var Contexto = new MyDbContext())
            {
                var lib = Contexto.libros.Find(_libro_idx.ISBN);
                lib.Stock--;


                Alquileres alquileres = new Alquileres();
                DateTime _fechareserva = DateTime.Now;

                alquileres.ClienteId = _cliente_Id.ClienteId;                
                alquileres.IsbnId = _libro_idx.ISBN;
                alquileres.EstadoDeAlquileresId = 1;
                alquileres.FechaAlquiler = fecha_Alquiler;
                alquileres.FechaReserva = null;
                alquileres.FechaDevolucion = fecha_devolucion.AddDays(7);
                                           
                Contexto.alquileres.Add(alquileres);
                Contexto.SaveChanges();
                return alquileres;                
            }
        }
    }
}
