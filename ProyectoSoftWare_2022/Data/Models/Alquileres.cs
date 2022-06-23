using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoSoftWare_2022.Data.Models
{
    class Alquileres
    {
        public int Id { get; set; }

        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        [Column("EstadoId")]
        [ForeignKey("EstadoId")]
        public int EstadoDeAlquileresId { get; set; }
        public virtual EstadoDeAlquileres EstadoDeAlquleres { get; set; } = null;


        [ForeignKey("ISBN")]
        public string IsbnId { get; set; }
        public virtual Libros? Isbn { get; set; } = null;


        public DateTime? FechaAlquiler { get; set; } = null;
        public DateTime? FechaReserva { get; set; } = null;
        public DateTime? FechaDevolucion { get; set; } = null;      
    }
}
