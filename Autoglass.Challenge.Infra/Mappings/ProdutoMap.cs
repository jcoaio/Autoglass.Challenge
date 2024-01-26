using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace Autoglass.Challenge.Infra.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao).HasMaxLength(50).IsRequired();

            builder.Property(p => p.Situacao).HasMaxLength(10);

            builder.Property(p => p.DataFabricacao);
            builder.HasIndex(p => p.DataFabricacao);

            builder.Property(p => p.DataValidade);
            builder.HasOne(p => p.Fornecedor)
                   .WithMany(f => f.Produtos)
                   .HasForeignKey(p => p.IdFornecedor)
                   .OnDelete(DeleteBehavior.Restrict);



            builder.HasData(
                new Produto
                {
                    Id = 1,
                    Descricao = "Vidro Porta Renault Duster 2012 a 2015",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2023, 01, 29, 15, 8, 0),
                    DataValidade = new DateTime(2028, 01, 1, 18, 0, 0),
                    IdFornecedor = 1

                },
                new Produto
                {
                    Id = 2,
                    Descricao = "Parachoque Dianteiro Toyota Hilux",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2022, 11, 18, 9, 55, 18),
                    DataValidade = new DateTime(2026, 11, 30, 08, 0, 0),
                    IdFornecedor = 1
                },
                new Produto
                {
                    Id = 3,
                    Descricao = "Retrovisor Externo Toyota Rav4",
                    Situacao = SituacaoProduto.Inativo,
                    DataFabricacao = new DateTime(2019, 10, 22, 8, 45, 23),
                    DataValidade = new DateTime(2030, 10, 22, 8, 45, 23),
                    IdFornecedor = 2
                },
                new Produto
                {
                    Id = 4,
                    Descricao = "Palheta Parabrisa Volksawgen Gol",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2022, 12, 13, 12, 42, 56),
                    DataValidade = new DateTime(2024, 10, 1, 19, 30, 0),
                    IdFornecedor = 3
                }
            );
        }
    }
}
