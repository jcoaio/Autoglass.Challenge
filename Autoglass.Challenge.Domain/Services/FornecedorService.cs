using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Domain.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task<IEnumerable<Fornecedor>> GetAllAsync()
        {
            return await _fornecedorRepository.GetAllAsync();
        }
    }
}
