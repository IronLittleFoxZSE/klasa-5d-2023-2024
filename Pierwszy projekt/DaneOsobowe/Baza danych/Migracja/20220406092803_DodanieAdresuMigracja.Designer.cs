﻿// <auto-generated />
using System;
using DaneOsobowe.Baza_danych.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DaneOsobowe.Bazadanych.Migracja
{
    [DbContext(typeof(MojaBazaContext))]
    [Migration("20220406092803_DodanieAdresuMigracja")]
    partial class DodanieAdresuMigracja
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("DaneOsobowe.Baza_danych.Model.Adres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Miasto")
                        .HasColumnType("TEXT");

                    b.Property<string>("NrDomu")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ulica")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Adresy");
                });

            modelBuilder.Entity("DaneOsobowe.Baza_danych.Model.Osoba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AdresId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Imie")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("TEXT");

                    b.Property<int>("Wiek")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdresId");

                    b.ToTable("Osoby");
                });

            modelBuilder.Entity("DaneOsobowe.Baza_danych.Model.Osoba", b =>
                {
                    b.HasOne("DaneOsobowe.Baza_danych.Model.Adres", "Adres")
                        .WithMany()
                        .HasForeignKey("AdresId");
                });
#pragma warning restore 612, 618
        }
    }
}
