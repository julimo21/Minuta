﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Minuta.App.Persistencia;

#nullable disable

namespace Minuta.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220921162713_Nueva9")]
    partial class Nueva9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Minuta.App.Dominio.MinutaVigilancia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("asunto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("minVig");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MinutaVigilancia");
                });

            modelBuilder.Entity("Minuta.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("per");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Minuta.App.Dominio.Vehiculo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoVehiculo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("veh");
                });

            modelBuilder.Entity("Minuta.App.Dominio.Administrador", b =>
                {
                    b.HasBaseType("Minuta.App.Dominio.Persona");

                    b.Property<string>("celularAdm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correoAdm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("Minuta.App.Dominio.MinutaCorrespondencia", b =>
                {
                    b.HasBaseType("Minuta.App.Dominio.MinutaVigilancia");

                    b.Property<string>("firmaRecibido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MinutaCorrespondencia_observaciones");

                    b.Property<string>("personaEntrega")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personaRecibe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("residenteid")
                        .HasColumnType("int")
                        .HasColumnName("MinutaCorrespondencia_residenteid");

                    b.Property<string>("tipoCorrespondencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("residenteid");

                    b.HasDiscriminator().HasValue("MinutaCorrespondencia");
                });

            modelBuilder.Entity("Minuta.App.Dominio.MinutaEventos", b =>
                {
                    b.HasBaseType("Minuta.App.Dominio.MinutaVigilancia");

                    b.Property<string>("anotaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("MinutaEventos");
                });

            modelBuilder.Entity("Minuta.App.Dominio.MinutaVehiculoResidentes", b =>
                {
                    b.HasBaseType("Minuta.App.Dominio.MinutaVigilancia");

                    b.Property<string>("observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("residenteid")
                        .HasColumnType("int");

                    b.Property<int>("vehiculoResid")
                        .HasColumnType("int");

                    b.HasIndex("residenteid");

                    b.HasIndex("vehiculoResid");

                    b.HasDiscriminator().HasValue("MinutaVehiculoResidentes");
                });

            modelBuilder.Entity("Minuta.App.Dominio.MinutaVehiculoVisitantes", b =>
                {
                    b.HasBaseType("Minuta.App.Dominio.MinutaVigilancia");

                    b.Property<string>("fechaSalidaVehVis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaSalidaVehVis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numParqueaderoVis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vehiculoVisid")
                        .HasColumnType("int");

                    b.Property<int>("visitanteid")
                        .HasColumnType("int");

                    b.HasIndex("vehiculoVisid");

                    b.HasIndex("visitanteid");

                    b.HasDiscriminator().HasValue("MinutaVehiculoVisitantes");
                });

            modelBuilder.Entity("Minuta.App.Dominio.MinutaVisitante", b =>
                {
                    b.HasBaseType("Minuta.App.Dominio.MinutaVigilancia");

                    b.Property<string>("fechaSalidaVis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaSalidaVis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("visitanteid")
                        .HasColumnType("int")
                        .HasColumnName("MinutaVisitante_visitanteid");

                    b.HasIndex("visitanteid");

                    b.HasDiscriminator().HasValue("MinutaVisitante");
                });

            modelBuilder.Entity("Minuta.App.Dominio.Residente", b =>
                {
                    b.HasBaseType("Minuta.App.Dominio.Persona");

                    b.Property<string>("celularRes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numApartamentoRes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numParqueaderoRes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Residente");
                });

            modelBuilder.Entity("Minuta.App.Dominio.Vigilante", b =>
                {
                    b.HasBaseType("Minuta.App.Dominio.Persona");

                    b.Property<string>("empresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("turno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Vigilante");
                });

            modelBuilder.Entity("Minuta.App.Dominio.Visitante", b =>
                {
                    b.HasBaseType("Minuta.App.Dominio.Persona");

                    b.Property<string>("numApartamentoVis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Visitante");
                });

            modelBuilder.Entity("Minuta.App.Dominio.MinutaCorrespondencia", b =>
                {
                    b.HasOne("Minuta.App.Dominio.Residente", "residente")
                        .WithMany()
                        .HasForeignKey("residenteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("residente");
                });

            modelBuilder.Entity("Minuta.App.Dominio.MinutaVehiculoResidentes", b =>
                {
                    b.HasOne("Minuta.App.Dominio.Residente", "residente")
                        .WithMany()
                        .HasForeignKey("residenteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Minuta.App.Dominio.Vehiculo", "vehiculoRes")
                        .WithMany()
                        .HasForeignKey("vehiculoResid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("residente");

                    b.Navigation("vehiculoRes");
                });

            modelBuilder.Entity("Minuta.App.Dominio.MinutaVehiculoVisitantes", b =>
                {
                    b.HasOne("Minuta.App.Dominio.Vehiculo", "vehiculoVis")
                        .WithMany()
                        .HasForeignKey("vehiculoVisid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Minuta.App.Dominio.Visitante", "visitante")
                        .WithMany()
                        .HasForeignKey("visitanteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("vehiculoVis");

                    b.Navigation("visitante");
                });

            modelBuilder.Entity("Minuta.App.Dominio.MinutaVisitante", b =>
                {
                    b.HasOne("Minuta.App.Dominio.Visitante", "visitante")
                        .WithMany()
                        .HasForeignKey("visitanteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("visitante");
                });
#pragma warning restore 612, 618
        }
    }
}
