using Autoglass.Challenge.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Application.Interfaces
{
    public interface IFornecedorApplicationService
    {
        Task<IEnumerable<FornecedorResponse>> GetAllAsync();

    }
}
