﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteStand.Context;

namespace TesteStand.Migrations
{
    [DbContext(typeof(EmpresaContext))]
    partial class EmpresaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteStand.Models.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Capital")
                        .HasColumnType("float");

                    b.Property<string>("Classificacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Data_fundacao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Quarentena")
                        .HasColumnType("bit");

                    b.Property<string>("Razao_social")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Status_cliente")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Cnpj")
                        .IsUnique()
                        .HasFilter("[Cnpj] IS NOT NULL");

                    b.HasIndex("Razao_social")
                        .IsUnique()
                        .HasFilter("[Razao_social] IS NOT NULL");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}