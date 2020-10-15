﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sofas.Domain;

namespace Sofas.Domain.Migrations
{
    [DbContext(typeof(SofasContext))]
    [Migration("20201010002135_persona")]
    partial class persona
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sofas.Domain.Models.Consumibles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Producto");

                    b.HasKey("id");

                    b.ToTable("consumibles");
                });

            modelBuilder.Entity("Sofas.Domain.Models.Consumibles_Count", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cantidad");

                    b.HasKey("id");

                    b.ToTable("consumibles_Counts");
                });

            modelBuilder.Entity("Sofas.Domain.Models.Instrumentos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Consumibles")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("Instrumentos");
                });

            modelBuilder.Entity("Sofas.Domain.Models.Personas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido");

                    b.Property<string>("email");

                    b.Property<string>("nombre")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Sofas.Domain.Models.ToDo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("completado");

                    b.Property<string>("descripcion");

                    b.HasKey("id");

                    b.ToTable("toDos");
                });
#pragma warning restore 612, 618
        }
    }
}