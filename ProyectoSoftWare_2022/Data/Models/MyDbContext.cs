using Microsoft.EntityFrameworkCore;
using ProyectoSoftWare_2022.Data.Settings;

namespace ProyectoSoftWare_2022.Data.Models
{
    class MyDbContext : DbContext
    {
        public MyDbContext()
        {
            //Contrustor por defecto.
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=M9_DeJulio;Trusted_Connection=True;");
            //Conexion a la base de datos (aca podes tener mas de 1)
        }
        protected override void OnModelCreating(ModelBuilder Modelos)
        {
            new SettingsAlquileres(Modelos.Entity<Alquileres>());
            new SettingsCliente(Modelos.Entity<Cliente>());
            new SettingsEstadoAlquiler(Modelos.Entity<EstadoDeAlquileres>());
            new SettingsLibro(Modelos.Entity<Libros>());

            base.OnModelCreating(Modelos);
            //Conexion con los Modemos (Es decir donde pones q datos tiene las tablas)
        }
        public DbSet<Alquileres> alquileres { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<EstadoDeAlquileres> estadoDeAlquileres { get; set; }
        public DbSet<Libros> libros { get; set; }
        //Conexion a las tablas
    }
}
