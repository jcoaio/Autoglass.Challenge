using Autoglass.Challenge.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Autoglass.Challenge.Infra.Mappings
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao).HasMaxLength(50).IsRequired();

            builder.Property(p => p.Cnpj).HasMaxLength(20);

            builder.HasData(
                new Fornecedor
                {
                    Id = 1,
                    Descricao = "Fornecedor 01",
                    Cnpj = "11.111.111/0001-01"
                },
                 new Fornecedor
                 {
                     Id = 2,
                     Descricao = "Fornecedor 02",
                     Cnpj = "22.222.222/0001-01"
                 },
                new Fornecedor
                {
                    Id = 3,
                    Descricao = "Fornecedor 03",
                    Cnpj = "33.333.333/0001-01"
                }
            );
        }
    }
}
