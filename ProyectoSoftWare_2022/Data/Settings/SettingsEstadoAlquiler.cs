using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Data.Settings
{
    class SettingsEstadoAlquiler
    {
        public SettingsEstadoAlquiler(EntityTypeBuilder<EstadoDeAlquileres> BuilderE_D_A)
        {
            //Primary Key
            BuilderE_D_A.HasKey(X => X.EstadoId);

            //Others Entitys.
            BuilderE_D_A.Property(X => X.Descripcion).HasMaxLength(45).IsRequired();

            //Foraing Key.
            //BuilderE_D_A.HasMany(X => X.Alquileres_EA).WithOne(Z => Z.estadosId).HasForeignKey(X => X.Id);
            //Esto no se si esta del todo bien hecho.

            BuilderE_D_A.HasData(new EstadoDeAlquileres
            {
                EstadoId = 1,
                Descripcion = "Alquilado"   //Libro Alquilado

            });
            BuilderE_D_A.HasData(new EstadoDeAlquileres
            {
                EstadoId = 2,
                Descripcion = "Reservado"   //Libro Reservado

            });
            BuilderE_D_A.HasData(new EstadoDeAlquileres
            {
                EstadoId = 3,
                Descripcion = "Cancelado"

            });
        }
    }
}
