﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoSoftWare_2022.Data.Models;

#nullable disable

namespace ProyectoSoftWare_2022.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProyectoSoftWare_2022.Data.Models.Alquileres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("FechaAlquiler")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDevolucion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaReserva")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("IsbnId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<int>("estadoId")
                        .HasColumnType("int");

                    b.Property<int>("estadosEstadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IsbnId");

                    b.HasIndex("clienteId");

                    b.HasIndex("estadosEstadoId");

                    b.ToTable("alquileres");
                });

            modelBuilder.Entity("ProyectoSoftWare_2022.Data.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("ClienteId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("ProyectoSoftWare_2022.Data.Models.EstadoDeAlquileres", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoId"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("EstadoId");

                    b.ToTable("estadoDeAlquileres");

                    b.HasData(
                        new
                        {
                            EstadoId = 1,
                            Descripcion = "Alquilado"
                        },
                        new
                        {
                            EstadoId = 2,
                            Descripcion = "Reservado"
                        },
                        new
                        {
                            EstadoId = 3,
                            Descripcion = "Cancelado"
                        });
                });

            modelBuilder.Entity("ProyectoSoftWare_2022.Data.Models.Libros", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Edicion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Editorial")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("ISBN");

                    b.ToTable("libros");

                    b.HasData(
                        new
                        {
                            ISBN = "1407134612",
                            Autor = "Maggie Stiefvater",
                            Edicion = "1",
                            Editorial = "Sm",
                            Imagen = "https://ecat-server.grupo-sm.com/ecat_Imagenes/Original/141850_194725.jpg",
                            Stock = 0,
                            Titulo = "La profecia del cuervo"
                        },
                        new
                        {
                            ISBN = "8467559217",
                            Autor = "Maggie Stiefvater",
                            Edicion = "1",
                            Editorial = "Sm",
                            Imagen = "https://http2.mlstatic.com/D_NQ_NP_602833-MLA41780313102_052020-O.jpg",
                            Stock = 2,
                            Titulo = "Los saqueadores del sueño"
                        },
                        new
                        {
                            ISBN = "9789871783144",
                            Autor = "Rick Riordan",
                            Edicion = "1",
                            Editorial = "Montena",
                            Imagen = "https://images.cdn3.buscalibre.com/fit-in/360x360/90/4a/904a56e1088179d1aa7cce5421c1f32a.jpg",
                            Stock = 4,
                            Titulo = "La Piramide Roja"
                        },
                        new
                        {
                            ISBN = "9789878000183",
                            Autor = "Rick Riordan",
                            Edicion = "1",
                            Editorial = "Salamandra",
                            Imagen = "https://images.cdn2.buscalibre.com/fit-in/360x360/b8/86/b886a5ec056f6eea24f542dde45f11ef.jpg",
                            Stock = 3,
                            Titulo = "El ladron del rayo"
                        },
                        new
                        {
                            ISBN = "9788498387193",
                            Autor = "Rick Riordan",
                            Edicion = "1",
                            Editorial = "Salamandra",
                            Imagen = "https://m.media-amazon.com/images/I/41ucgFcdpsL._AC_SY580_.jpg",
                            Stock = 3,
                            Titulo = "El mar de los Monstruos"
                        },
                        new
                        {
                            ISBN = "8408083805",
                            Autor = "Cassandra Clare",
                            Edicion = "2014",
                            Editorial = "Booket",
                            Imagen = "https://imagessl1.casadellibro.com/a/l/t7/01/9788408083801.jpg",
                            Stock = 3,
                            Titulo = "Cazadores de Sombras - Ciudad de Ceniza"
                        },
                        new
                        {
                            ISBN = "9789875807105",
                            Autor = "Cassandra Clare",
                            Edicion = "1",
                            Editorial = "Booket",
                            Imagen = "https://images.cdn2.buscalibre.com/fit-in/360x360/b5/e4/b5e4f0f82c7df83d073462f6dea866ad.jpg",
                            Stock = 2,
                            Titulo = "Cazadores de Sombras - Ciudad de Hueso"
                        },
                        new
                        {
                            ISBN = "9789878000107",
                            Autor = "J.K. Rowling",
                            Edicion = "1",
                            Editorial = "Salamandra",
                            Imagen = "https://http2.mlstatic.com/D_NQ_NP_722711-MLA42906730908_072020-O.jpg",
                            Stock = 5,
                            Titulo = "Harry Potter y la Piedra Filosofa"
                        },
                        new
                        {
                            ISBN = "9789878000114",
                            Autor = "J.K. Rowling",
                            Edicion = "1",
                            Editorial = "Salamandra",
                            Imagen = "https://images.cdn2.buscalibre.com/fit-in/360x360/ad/4d/ad4df4ba516014a9fc39a0288a70957f.jpg",
                            Stock = 4,
                            Titulo = "Harry Potter Y La Camara Secreta"
                        },
                        new
                        {
                            ISBN = "9789878000121",
                            Autor = "J.K. Rowling",
                            Edicion = "1",
                            Editorial = "Salamandra",
                            Imagen = "https://contentv2.tap-commerce.com/cover/large/9789878000121_1.jpg?id_com=1113",
                            Stock = 3,
                            Titulo = "Harry Potter y el Prisionero de Azkaban"
                        });
                });

            modelBuilder.Entity("ProyectoSoftWare_2022.Data.Models.Alquileres", b =>
                {
                    b.HasOne("ProyectoSoftWare_2022.Data.Models.Libros", "ISBN")
                        .WithMany("alquileres_L")
                        .HasForeignKey("IsbnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoSoftWare_2022.Data.Models.Cliente", "clientes")
                        .WithMany("Alquiler_C")
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoSoftWare_2022.Data.Models.EstadoDeAlquileres", "estados")
                        .WithMany("Alquileres_EA")
                        .HasForeignKey("estadosEstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ISBN");

                    b.Navigation("clientes");

                    b.Navigation("estados");
                });

            modelBuilder.Entity("ProyectoSoftWare_2022.Data.Models.Cliente", b =>
                {
                    b.Navigation("Alquiler_C");
                });

            modelBuilder.Entity("ProyectoSoftWare_2022.Data.Models.EstadoDeAlquileres", b =>
                {
                    b.Navigation("Alquileres_EA");
                });

            modelBuilder.Entity("ProyectoSoftWare_2022.Data.Models.Libros", b =>
                {
                    b.Navigation("alquileres_L");
                });
#pragma warning restore 612, 618
        }
    }
}
