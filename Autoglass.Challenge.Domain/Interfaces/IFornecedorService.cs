using Autoglass.Challenge.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Domain.Interfaces
{
    public interface IFornecedorService
    {
        Task<IEnumerable<Fornecedor>> GetAllAsync();

    }
}
