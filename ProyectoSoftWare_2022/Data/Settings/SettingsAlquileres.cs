using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Data.Settings
{
    class SettingsAlquileres
    {
        public SettingsAlquileres(EntityTypeBuilder<Alquileres> BuilderAlq)
        {
            //Primary Key.
            BuilderAlq.HasKey(X => X.Id);

            //Others Entitys.
            BuilderAlq.Property(X => X.FechaAlquiler);
            BuilderAlq.Property(X => X.FechaDevolucion);
            BuilderAlq.Property(X => X.FechaReserva);
            
        }
    }
}
