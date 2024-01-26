using Autoglass.Challenge.Application.Interfaces;
using Autoglass.Challenge.Domain.Interfaces;
using Autoglass.Challenge.Domain.Services;
using Autoglass.Challenge.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Application.Service
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorService _fornecedorService;
        private readonly IMapper _mapper;

        public FornecedorApplicationService(IFornecedorService fornecedorService, IMapper mapper)
        {
            _fornecedorService = fornecedorService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FornecedorResponse>> GetAllAsync()
        {
            try
            {
                return _mapper.Map<IEnumerable<FornecedorResponse>>(await _fornecedorService.GetAllAsync());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
