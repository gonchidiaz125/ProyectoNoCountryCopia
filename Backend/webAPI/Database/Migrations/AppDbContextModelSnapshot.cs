﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webAPI.Database;

#nullable disable

namespace webAPI.Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("webAPI.Models.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Localidad");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Avellaneda"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Río Cuarto"
                        });
                });

            modelBuilder.Entity("webAPI.Models.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Años")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Borrado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Meses")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlImagen")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Mascota");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Años = 1,
                            Borrado = false,
                            Descripcion = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facere eum animi saepe odio accusantium.",
                            Especie = "Gato",
                            Estado = "Disponible",
                            IdUsuario = 1,
                            Meses = 3,
                            Nombre = "Michi",
                            Raza = "Gris",
                            UrlImagen = "https://w.wallhaven.cc/full/p9/wallhaven-p9gr59.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Años = 2,
                            Borrado = false,
                            Descripcion = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facere eum animi saepe odio accusantium.",
                            Especie = "Gato",
                            Estado = "Disponible",
                            IdUsuario = 1,
                            Meses = 1,
                            Nombre = "Michifus",
                            Raza = "Marmolado",
                            UrlImagen = "https://w.wallhaven.cc/full/lq/wallhaven-lqm2zl.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Años = 1,
                            Borrado = false,
                            Descripcion = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facere eum animi saepe odio accusantium.",
                            Especie = "Perro",
                            Estado = "Disponible",
                            IdUsuario = 1,
                            Meses = 1,
                            Nombre = "Firu",
                            Raza = "Aleman",
                            UrlImagen = "https://w.wallhaven.cc/full/4x/wallhaven-4xjqel.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Años = 2,
                            Borrado = false,
                            Descripcion = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facere eum animi saepe odio accusantium.",
                            Especie = "Perro",
                            Estado = "Disponible",
                            IdUsuario = 1,
                            Meses = 2,
                            Nombre = "Firulais",
                            Raza = "Callejero",
                            UrlImagen = "https://w.wallhaven.cc/full/p9/wallhaven-p9gr59.jpg"
                        });
                });

            modelBuilder.Entity("webAPI.Models.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Provincia");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Buenos Aires"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Ciudad Autónoma de Buenos Aires"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Catamarca"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Chaco"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Chubut"
                        },
                        new
                        {
                            Id = 6,
                            Nombre = "Córdoba"
                        },
                        new
                        {
                            Id = 7,
                            Nombre = "Corrientes"
                        },
                        new
                        {
                            Id = 8,
                            Nombre = "Entre Ríos"
                        },
                        new
                        {
                            Id = 9,
                            Nombre = "Formosa"
                        },
                        new
                        {
                            Id = 10,
                            Nombre = "Jujuy"
                        },
                        new
                        {
                            Id = 11,
                            Nombre = "La Pampa"
                        },
                        new
                        {
                            Id = 12,
                            Nombre = "La Rioja"
                        },
                        new
                        {
                            Id = 13,
                            Nombre = "Mendoza"
                        },
                        new
                        {
                            Id = 14,
                            Nombre = "Misiones"
                        },
                        new
                        {
                            Id = 15,
                            Nombre = "Neuquén"
                        },
                        new
                        {
                            Id = 16,
                            Nombre = "Río Negro"
                        },
                        new
                        {
                            Id = 17,
                            Nombre = "Salta"
                        },
                        new
                        {
                            Id = 18,
                            Nombre = "San Juan"
                        },
                        new
                        {
                            Id = 19,
                            Nombre = "San Luis"
                        },
                        new
                        {
                            Id = 20,
                            Nombre = "Santa Cruz"
                        },
                        new
                        {
                            Id = 21,
                            Nombre = "Santa Fe"
                        },
                        new
                        {
                            Id = 22,
                            Nombre = "Santiago del Estero"
                        },
                        new
                        {
                            Id = 23,
                            Nombre = "Tierra del Fuego"
                        });
                });

            modelBuilder.Entity("webAPI.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Rol");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Refugio"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Cliente"
                        });
                });

            modelBuilder.Entity("webAPI.Models.Solicitud", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdMascota")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdMascota");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Solicitud");
                });

            modelBuilder.Entity("webAPI.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Borrado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdLocalidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProvincia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdRol")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("IdLocalidad");

                    b.HasIndex("IdProvincia");

                    b.HasIndex("IdRol");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "SRL",
                            Borrado = false,
                            Descripcion = "",
                            Direccion = "",
                            Email = "refugio@g.com",
                            IdLocalidad = 1,
                            IdProvincia = 21,
                            IdRol = 2,
                            Nombre = "Refugio",
                            PasswordHash = new byte[] { 200, 65, 251, 184, 55, 177, 67, 156, 203, 72, 252, 152, 132, 121, 104, 85, 230, 164, 16, 65, 58, 53, 45, 40, 161, 225, 152, 26, 109, 98, 171, 25, 51, 143, 231, 79, 179, 49, 15, 61, 233, 147, 0, 46, 150, 41, 101, 132, 85, 20, 205, 196, 168, 71, 182, 24, 20, 203, 252, 50, 185, 13, 220, 163 },
                            PasswordSalt = new byte[] { 254, 226, 158, 134, 41, 147, 94, 240, 233, 37, 180, 139, 62, 203, 37, 59, 72, 137, 203, 215, 208, 87, 125, 205, 101, 208, 224, 234, 201, 198, 104, 184, 229, 235, 85, 171, 44, 92, 182, 219, 140, 144, 177, 48, 102, 109, 143, 93, 54, 42, 50, 58, 158, 19, 116, 32, 94, 12, 189, 53, 230, 57, 149, 142, 55, 110, 182, 144, 191, 78, 72, 13, 198, 45, 19, 21, 169, 162, 222, 185, 106, 83, 193, 50, 67, 135, 187, 5, 224, 102, 99, 14, 172, 72, 6, 216, 32, 10, 53, 21, 7, 140, 229, 70, 75, 31, 18, 219, 72, 93, 200, 13, 98, 18, 161, 3, 55, 11, 8, 238, 68, 237, 28, 146, 113, 30, 137, 156 }
                        });
                });

            modelBuilder.Entity("webAPI.Models.Mascota", b =>
                {
                    b.HasOne("webAPI.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("webAPI.Models.Solicitud", b =>
                {
                    b.HasOne("webAPI.Models.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("IdMascota")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webAPI.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("webAPI.Models.Usuario", b =>
                {
                    b.HasOne("webAPI.Models.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("IdLocalidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webAPI.Models.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("IdProvincia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webAPI.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Localidad");

                    b.Navigation("Provincia");

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}
