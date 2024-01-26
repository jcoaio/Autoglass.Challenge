using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.Domain.Parameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Domain.Interfaces
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> GetAllAsync(ProdutosParameters produtosParameters);
        Task<Produto> GetByIdAsync(int id);
        Task InsertProdutoAsync(Produto produto);
        Task UpdateProdutoAsync(Produto produto);
        Task DeleteProdutoAsync(int id);
        Task<bool> ExistAsync(int id);
    }
}
