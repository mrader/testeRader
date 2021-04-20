﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(TotvsContext))]
    partial class TotvsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Model.Entidades.PuntoVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PuntoVenta");
                });

            modelBuilder.Entity("Model.Entidades.Transaccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ImporteRealPagado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ImporteTotalAPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("clienteId")
                        .HasColumnType("int");

                    b.Property<int?>("puntoVentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.HasIndex("puntoVentaId");

                    b.ToTable("Transaccion");
                });

            modelBuilder.Entity("Model.Entidades.Transaccion", b =>
                {
                    b.HasOne("Model.Entidades.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteId");

                    b.HasOne("Model.Entidades.PuntoVenta", "puntoVenta")
                        .WithMany()
                        .HasForeignKey("puntoVentaId");

                    b.Navigation("cliente");

                    b.Navigation("puntoVenta");
                });
#pragma warning restore 612, 618
        }
    }
}