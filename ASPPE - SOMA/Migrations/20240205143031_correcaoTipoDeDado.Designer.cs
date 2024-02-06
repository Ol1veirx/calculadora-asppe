﻿// <auto-generated />
using ASPPE___SOMA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPPE___SOMA.Migrations
{
    [DbContext(typeof(ASPPE___SOMAContext))]
    [Migration("20240205143031_correcaoTipoDeDado")]
    partial class correcaoTipoDeDado
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ASPPE___SOMA.Models.Equipes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("MaiorPeixe")
                        .HasColumnType("double");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Peso")
                        .HasColumnType("double");

                    b.Property<double>("Pontos")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Equipes");
                });
#pragma warning restore 612, 618
        }
    }
}