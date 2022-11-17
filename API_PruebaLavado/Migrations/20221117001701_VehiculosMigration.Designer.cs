﻿// <auto-generated />
using System;
using API_PruebaLavado.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_PruebaLavado.Migrations
{
    [DbContext(typeof(VehiculoDBContext))]
    [Migration("20221117001701_VehiculosMigration")]
    partial class VehiculosMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_PruebaLavado.Models.Vehiculo", b =>
                {
                    b.Property<Guid>("ID_Vehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Dueno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Vehiculo");

                    b.ToTable("Vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
