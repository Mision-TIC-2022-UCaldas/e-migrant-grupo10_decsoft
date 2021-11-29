﻿// <auto-generated />
using System;
using Ganaderia.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ganaderia.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211129024631_inicio")]
    partial class inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Ganaderia.App.Dominio.Migrante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion_actual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("No_Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais_origen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situacion_laboral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Migrantes");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Necesidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MigranteId")
                        .HasColumnType("int");

                    b.Property<string>("alimentacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("alojamiento_permanente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("alojamiento_temporal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ayuda_legal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("educacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empleo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("salud")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MigranteId");

                    b.ToTable("Necesidades");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("NecesidadId")
                        .HasColumnType("int");

                    b.Property<string>("alojamiento_permanente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("alojamiento_temporal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("comida_preparada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("educacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empleo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("juridicos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("otros")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("salud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("viveres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NecesidadId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Necesidad", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.Migrante", "Migrante")
                        .WithMany("Necesidad")
                        .HasForeignKey("MigranteId");

                    b.Navigation("Migrante");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Servicio", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.Necesidad", "Necesidad")
                        .WithMany("Servicio")
                        .HasForeignKey("NecesidadId");

                    b.Navigation("Necesidad");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Migrante", b =>
                {
                    b.Navigation("Necesidad");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Necesidad", b =>
                {
                    b.Navigation("Servicio");
                });
#pragma warning restore 612, 618
        }
    }
}