﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektSklep.Dane;

namespace ProjektSklep.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjektSklep.Models.But", b =>
                {
                    b.Property<int>("ButId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProducentId")
                        .HasColumnType("int");

                    b.Property<int>("kategoriaButa")
                        .HasColumnType("int");

                    b.HasKey("ButId");

                    b.HasIndex("ProducentId");

                    b.ToTable("Buty");
                });

            modelBuilder.Entity("ProjektSklep.Models.Kolorystyka", b =>
                {
                    b.Property<int>("KolorystykaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ButId")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KolorystykaId");

                    b.HasIndex("ButId");

                    b.ToTable("Kolorystyki");
                });

            modelBuilder.Entity("ProjektSklep.Models.Producent", b =>
                {
                    b.Property<int>("ProducentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazwaProducenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProducentId");

                    b.ToTable("Producenci");
                });

            modelBuilder.Entity("ProjektSklep.Models.But", b =>
                {
                    b.HasOne("ProjektSklep.Models.Producent", "Producent")
                        .WithMany("But")
                        .HasForeignKey("ProducentId");

                    b.Navigation("Producent");
                });

            modelBuilder.Entity("ProjektSklep.Models.Kolorystyka", b =>
                {
                    b.HasOne("ProjektSklep.Models.But", null)
                        .WithMany("Kolorystyka")
                        .HasForeignKey("ButId");
                });

            modelBuilder.Entity("ProjektSklep.Models.But", b =>
                {
                    b.Navigation("Kolorystyka");
                });

            modelBuilder.Entity("ProjektSklep.Models.Producent", b =>
                {
                    b.Navigation("But");
                });
#pragma warning restore 612, 618
        }
    }
}
