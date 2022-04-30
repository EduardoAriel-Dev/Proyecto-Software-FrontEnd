using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSoftWare_2022.Data.Models
{
    class Alquileres
    {   
        public int Id { get; set; }

        [ForeignKey("ClienteId")]
        public virtual int clienteId { get; set; }  
        public virtual Cliente? clientes { get; set; } = null;


        [ForeignKey("EstadoId")]
        public virtual int estadoId { get; set; }
        public virtual EstadoDeAlquileres estados { get; set; } = null;


        [ForeignKey("ISBN")]
        public virtual string IsbnId { get; set; }
        public virtual Libros? ISBN { get; set; } = null;


        public DateTime? FechaAlquiler { get; set; } = null;
        public DateTime? FechaReserva { get; set; } = null;
        public DateTime? FechaDevolucion { get; set; } = null;      
    }
}
