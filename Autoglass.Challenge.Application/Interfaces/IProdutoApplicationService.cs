using Autoglass.Challenge.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Application.Interfaces
{
    public interface IProdutoApplicationService
    {
        Task<ProdutoPaginacaoResponse> GetAllAsync(ProdutoPaginacaoRequest paginacaoRequest);
        Task<ProdutoResponse> GetByIdAsync(int id);
        Task InsertProdutoAsync(ProdutoInsertRequest request);
        Task UpdateProdutoAsync(ProdutoUpdateRequest request);
        Task DeleteProdutoAsync(int id);
        Task<bool> ExistAsync(int id);

    }
}
