using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.Domain.Enums;
using Autoglass.Challenge.Domain.Interfaces;
using Autoglass.Challenge.Domain.Parameters;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Infra.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        protected readonly AutoglassDbContext context;

        public ProdutoRepository(AutoglassDbContext context)
        {
            this.context = context;
        }

        public async Task DeleteProdutoAsync(Produto produto)
        {
            produto.Situacao = SituacaoProduto.Inativo;
            await UpdateProdutoAsync(produto);
            await context.SaveChangesAsync();
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await context.Produto.AnyAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Produto>> GetAllAsync(ProdutosParameters produtosParameters)
        {
            IQueryable<Produto> consulta;

            consulta = context.Produto.Include(p => p.Fornecedor).Where(p =>
                    p.DataFabricacao >= produtosParameters.DataFabricacaoInicial &&
                    p.DataFabricacao <= produtosParameters.DataFabricacaoFinal &&
                    p.DataValidade >= produtosParameters.DatavalidadeInicial &&
                    p.DataValidade <= produtosParameters.DatavalidadeFinal);

            if (produtosParameters.Situacao != null)
            {
                consulta = consulta.Where(p => p.Situacao == produtosParameters.Situacao);
            }

            return (await consulta.ToListAsync())
                .OrderBy(p => p.Id)
                .Skip(produtosParameters.Skip)
                .Take(produtosParameters.Take);
        }

        public async Task<Produto> GetByIdAsync(int id)
        {
            return await context.Produto.Include(p => p.Fornecedor).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task InsertProdutoAsync(Produto produto)
        {
            await context.AddAsync(produto);
            await context.SaveChangesAsync();
        }

        public async Task UpdateProdutoAsync(Produto produto)
        {
            var prod = await GetByIdAsync(produto.Id);
            //produto.Situacao = prod.Situacao;
            context.Entry(prod).CurrentValues.SetValues(produto);
            await context.SaveChangesAsync();
        }
    }
}
