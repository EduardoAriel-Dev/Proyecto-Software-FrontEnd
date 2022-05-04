using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftWare_2022.Data.Models;


namespace ProyectoSoftWare_2022.Data.Commans
{
    class CrearReserva
    {
        EstadoDeAlquileres Estado_Alquiler = new EstadoDeAlquileres();

        public Alquileres _CrearReserva(Cliente _cliente_Id, EstadoDeAlquileres _estado_Id, Libros _libro_idx, DateTime _fechareserva)
        {
            using (var Contexto = new MyDbContext())
            {

                Alquileres alquileres = new Alquileres();              

                alquileres.ClienteId = _cliente_Id.ClienteId;
                //alquileres.clientes = _cliente_Id;                  
                alquileres.IsbnId = _libro_idx.ISBN;
                //alquileres.ISBN = _libro_idx;
                alquileres.EstadoDeAlquileresId = 2;
                //alquileres.estados = _estado_Id;
                alquileres.FechaAlquiler = null;
                alquileres.FechaReserva = _fechareserva;
                alquileres.FechaDevolucion = null;

                Contexto.alquileres.Add(alquileres);
                Contexto.SaveChanges();
                return alquileres;

            }
        }
    }
}
