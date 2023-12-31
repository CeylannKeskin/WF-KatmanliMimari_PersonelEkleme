﻿// <auto-generated />
using System;
using KatmanliMimari_PersonelEkleme2_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KatmanliMimari_PersonelEkleme2_DAL.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230707010835_initDb")]
    partial class initDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KatmanliMimari_PersonelEkleme2_Entities.IletisimBilgisi", b =>
                {
                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("PersonelID");

                    b.ToTable("IletisimBilgileri", (string)null);
                });

            modelBuilder.Entity("KatmanliMimari_PersonelEkleme2_Entities.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelID"), 1L, 1);

                    b.Property<string>("Birim")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TCKimlikNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char(11)");

                    b.HasKey("PersonelID");

                    b.ToTable("Personeller", (string)null);
                });

            modelBuilder.Entity("KatmanliMimari_PersonelEkleme2_Entities.IletisimBilgisi", b =>
                {
                    b.HasOne("KatmanliMimari_PersonelEkleme2_Entities.Personel", "Personel")
                        .WithOne("IletisimBilgisi")
                        .HasForeignKey("KatmanliMimari_PersonelEkleme2_Entities.IletisimBilgisi", "PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("KatmanliMimari_PersonelEkleme2_Entities.Personel", b =>
                {
                    b.Navigation("IletisimBilgisi")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
