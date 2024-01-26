﻿// <auto-generated />
using System;
using Autoglass.Challenge.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Autoglass.Challenge.Infra.Migrations
{
    [DbContext(typeof(AutoglassDbContext))]
    partial class AutoglassDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Autoglass.Challenge.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cnpj = "12.983.451/0001-01",
                            Descricao = "Fornecedor_01"
                        },
                        new
                        {
                            Id = 2,
                            Cnpj = "12.983.452/0001-01",
                            Descricao = "Fornecedor_02"
                        },
                        new
                        {
                            Id = 3,
                            Cnpj = "12.983.453/0001-01",
                            Descricao = "Fornecedor_03"
                        });
                });

            modelBuilder.Entity("Autoglass.Challenge.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFabricacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataValidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("IdFornecedor")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Situacao")
                        .HasMaxLength(10)
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DataFabricacao");

                    b.HasIndex("IdFornecedor");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataFabricacao = new DateTime(2023, 1, 29, 15, 8, 0, 0, DateTimeKind.Unspecified),
                            DataValidade = new DateTime(2028, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Vidro",
                            IdFornecedor = 1,
                            Situacao = 0
                        },
                        new
                        {
                            Id = 2,
                            DataFabricacao = new DateTime(2022, 11, 18, 9, 55, 18, 0, DateTimeKind.Unspecified),
                            DataValidade = new DateTime(2026, 11, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Retrovisor",
                            IdFornecedor = 1,
                            Situacao = 0
                        },
                        new
                        {
                            Id = 3,
                            DataFabricacao = new DateTime(2019, 10, 22, 8, 45, 23, 0, DateTimeKind.Unspecified),
                            DataValidade = new DateTime(2030, 10, 22, 8, 45, 23, 0, DateTimeKind.Unspecified),
                            Descricao = "Pelicula",
                            IdFornecedor = 2,
                            Situacao = 1
                        },
                        new
                        {
                            Id = 4,
                            DataFabricacao = new DateTime(2022, 12, 13, 12, 42, 56, 0, DateTimeKind.Unspecified),
                            DataValidade = new DateTime(2024, 10, 1, 19, 30, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Lanterna",
                            IdFornecedor = 3,
                            Situacao = 0
                        });
                });

            modelBuilder.Entity("Autoglass.Challenge.Domain.Entities.Produto", b =>
                {
                    b.HasOne("Autoglass.Challenge.Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("IdFornecedor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("Autoglass.Challenge.Domain.Entities.Fornecedor", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
