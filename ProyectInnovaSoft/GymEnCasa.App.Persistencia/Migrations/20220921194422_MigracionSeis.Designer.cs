﻿// <auto-generated />
using System;
using GymEnCasa.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GymEnCasa.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220921194422_MigracionSeis")]
    partial class MigracionSeis
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GymEnCasa.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Estatura")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<float>("IMC")
                        .HasColumnType("real");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObjetivoPersonal")
                        .HasColumnType("int");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("GymEnCasa.App.Dominio.PlanDeNutricion", b =>
                {
                    b.HasBaseType("GymEnCasa.App.Dominio.Persona");

                    b.Property<float>("CaloriasAgregadas")
                        .HasColumnType("real");

                    b.Property<float>("CaloriasQuemadas")
                        .HasColumnType("real");

                    b.Property<int>("Dieta")
                        .HasColumnType("int");

                    b.Property<string>("EstadoDieta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("FrecuenciaNutricion")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("PlanDeNutricion");
                });

            modelBuilder.Entity("GymEnCasa.App.Dominio.PlanDeRutinas", b =>
                {
                    b.HasBaseType("GymEnCasa.App.Dominio.Persona");

                    b.Property<string>("EstadoRutina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("PlanDeRutinas_Fecha");

                    b.Property<int>("Repeticiones")
                        .HasColumnType("int");

                    b.Property<string>("Rutina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rutinas")
                        .HasColumnType("int");

                    b.Property<string>("frecuenciaRutinas")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("PlanDeRutinas");
                });

            modelBuilder.Entity("GymEnCasa.App.Dominio.Usuario", b =>
                {
                    b.HasBaseType("GymEnCasa.App.Dominio.Persona");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
