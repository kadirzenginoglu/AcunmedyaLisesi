﻿// <auto-generated />
using System;
using AcunmedyaLisesi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcunmedyaLisesi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AcunmedyaLisesi.Web.Models.Egitimciler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DerslerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DerslerId");

                    b.ToTable("Egitimcies");
                });

            modelBuilder.Entity("AcunmedyaLisesi.Web.Models.Ogrenciler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ogrencies");
                });

            modelBuilder.Entity("AcunmedyaLisesi.Web.Models.Sinavlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DerslerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OgrencilerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DerslerId");

                    b.HasIndex("OgrencilerId");

                    b.ToTable("Sınavlars");
                });

            modelBuilder.Entity("YeniAcunmedyaLisesi.Models.Models.Dersler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DersAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OgrencilerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OgrencilerId");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("AcunmedyaLisesi.Web.Models.Egitimciler", b =>
                {
                    b.HasOne("YeniAcunmedyaLisesi.Models.Models.Dersler", "Dersler")
                        .WithMany("Egitimci")
                        .HasForeignKey("DerslerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dersler");
                });

            modelBuilder.Entity("AcunmedyaLisesi.Web.Models.Sinavlar", b =>
                {
                    b.HasOne("YeniAcunmedyaLisesi.Models.Models.Dersler", "Dersler")
                        .WithMany("Sinavlar")
                        .HasForeignKey("DerslerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcunmedyaLisesi.Web.Models.Ogrenciler", null)
                        .WithMany("Sınavlar")
                        .HasForeignKey("OgrencilerId");

                    b.Navigation("Dersler");
                });

            modelBuilder.Entity("YeniAcunmedyaLisesi.Models.Models.Dersler", b =>
                {
                    b.HasOne("AcunmedyaLisesi.Web.Models.Ogrenciler", null)
                        .WithMany("Dersler")
                        .HasForeignKey("OgrencilerId");
                });

            modelBuilder.Entity("AcunmedyaLisesi.Web.Models.Ogrenciler", b =>
                {
                    b.Navigation("Dersler");

                    b.Navigation("Sınavlar");
                });

            modelBuilder.Entity("YeniAcunmedyaLisesi.Models.Models.Dersler", b =>
                {
                    b.Navigation("Egitimci");

                    b.Navigation("Sinavlar");
                });
#pragma warning restore 612, 618
        }
    }
}
