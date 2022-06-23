
namespace ProyectoSoftWare_2022.Data.Models
{
    class EstadoDeAlquileres
    {
        public int EstadoId { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Alquileres> Alquileres_EA { get; set; }
    }
}
