﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TareasMCV;

#nullable disable

namespace TareasMCV.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240810064335_ArchivosAdjuntos")]
    partial class ArchivosAdjuntos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TareasMCV.Entidades.ArchivoAdjunto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<int>("TareaId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TareaId");

                    b.ToTable("ArchivosAdjuntos");
                });

            modelBuilder.Entity("TareasMCV.Entidades.Paso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<bool>("Realizado")
                        .HasColumnType("bit");

                    b.Property<int>("TareaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TareaId");

                    b.ToTable("Pasos");
                });

            modelBuilder.Entity("TareasMCV.Entidades.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("TareasMCV.Entidades.ArchivoAdjunto", b =>
                {
                    b.HasOne("TareasMCV.Entidades.Tarea", "Tarea")
                        .WithMany("ArchivosAdjuntos")
                        .HasForeignKey("TareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tarea");
                });

            modelBuilder.Entity("TareasMCV.Entidades.Paso", b =>
                {
                    b.HasOne("TareasMCV.Entidades.Tarea", "Tarea")
                        .WithMany("Pasos")
                        .HasForeignKey("TareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tarea");
                });

            modelBuilder.Entity("TareasMCV.Entidades.Tarea", b =>
                {
                    b.Navigation("ArchivosAdjuntos");

                    b.Navigation("Pasos");
                });
#pragma warning restore 612, 618
        }
    }
}
