using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
               
                    Alquileres alquileres = new Alquileres();
                    DateTime _fechareserva = DateTime.Now;

                    alquileres.ClienteId = _cliente_Id.ClienteId;
                    //alquileres.clientes = _cliente_Id;                  
                    alquileres.IsbnId = _libro_idx.ISBN;
                     //alquileres.ISBN = _libro_idx;
                    alquileres.EstadoDeAlquileresId = 1;
                    //alquileres.estados = _estado_Id;
                    alquileres.FechaAlquiler = fecha_Alquiler;
                    alquileres.FechaReserva = _fechareserva;
                    alquileres.FechaDevolucion = fecha_devolucion;
                    
                    Contexto.alquileres.Add(alquileres);
                    Contexto.SaveChanges();
                    return alquileres;
                
            }
        }
    }
}
