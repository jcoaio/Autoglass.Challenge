using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.Domain.Enums;
using Autoglass.Challenge.Domain.Interfaces;
using Autoglass.Challenge.Domain.Parameters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task DeleteProdutoAsync(int id)
        {
            var prod = await GetByIdAsync(id);
            if (prod.Situacao == SituacaoProduto.Ativo)
                await _produtoRepository.DeleteProdutoAsync(prod);

        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _produtoRepository.ExistAsync(id);
        }

        public async Task<IEnumerable<Produto>> GetAllAsync(ProdutosParameters produtosParameters)
        {
            return await _produtoRepository.GetAllAsync(produtosParameters);
        }

        public async Task<Produto> GetByIdAsync(int id)
        {
            return await _produtoRepository.GetByIdAsync(id);
        }

        public async Task InsertProdutoAsync(Produto produto)
        {
            if (!ValidarDataFabricacao(produto))
                throw new Exception("Data de fabricação inválida.");

            await _produtoRepository.InsertProdutoAsync(produto);
        }

        public async Task UpdateProdutoAsync(Produto produto)
        {
            if (!ValidarDataFabricacao(produto))
                throw new Exception("Data de fabricação inválida.");

            await _produtoRepository.UpdateProdutoAsync(produto);

        }

        private bool ValidarDataFabricacao(Produto produto)
        {
            if (produto.DataFabricacao >= produto.DataValidade)
                return false;

            return true;
        }
    }
}
