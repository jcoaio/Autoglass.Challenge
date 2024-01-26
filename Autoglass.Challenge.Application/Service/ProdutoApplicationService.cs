using Autoglass.Challenge.Application.Interfaces;
using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.Domain.Interfaces;
using Autoglass.Challenge.Domain.Parameters;
using Autoglass.Challenge.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Application.Service
{

    public class ProdutoApplicationService : IProdutoApplicationService
    {
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoApplicationService(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }

        public async Task DeleteProdutoAsync(int id)
        {
            try
            {
                await _produtoService.DeleteProdutoAsync(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<bool> ExistAsync(int id)
        {
            try
            {
                return await _produtoService.ExistAsync(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<ProdutoPaginacaoResponse> GetAllAsync(ProdutoPaginacaoRequest paginacaoRequest)
        {

            

            try
            {
                ValidarParametros(paginacaoRequest);

                var parametros = _mapper.Map<ProdutosParameters>(paginacaoRequest);

                var produtos = _mapper.Map<IEnumerable<ProdutoResponse>>(await _produtoService.GetAllAsync(parametros));
                return new ProdutoPaginacaoResponse
                {
                    Produtos = produtos,
                    Skip = paginacaoRequest.Skip,
                    Take = paginacaoRequest.Take,
                    Count = produtos.Count()
                };
            }
            catch (Exception)
            {
                throw;
            }

        }



        public async Task<ProdutoResponse> GetByIdAsync(int id)
        {
            try
            {
                return _mapper.Map<ProdutoResponse>(await _produtoService.GetByIdAsync(id));
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task InsertProdutoAsync(ProdutoInsertRequest request)
        {
            try
            {
                await _produtoService.InsertProdutoAsync(_mapper.Map<Produto>(request));
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task UpdateProdutoAsync(ProdutoUpdateRequest request)
        {
            try
            {
                await _produtoService.UpdateProdutoAsync(_mapper.Map<Produto>(request));
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void ValidarParametros(ProdutoPaginacaoRequest paginacaoRequest)
        {
            paginacaoRequest.DataFabricacaoInicial = paginacaoRequest.DataFabricacaoInicial == null ? DateTime.MinValue : paginacaoRequest.DataFabricacaoInicial;
            paginacaoRequest.DataFabricacaoFinal = paginacaoRequest.DataFabricacaoFinal == null ? DateTime.MaxValue : paginacaoRequest.DataFabricacaoFinal;

            paginacaoRequest.DatavalidadeInicial = paginacaoRequest.DatavalidadeInicial == null ? DateTime.MinValue : paginacaoRequest.DatavalidadeInicial;
            paginacaoRequest.DatavalidadeFinal = paginacaoRequest.DatavalidadeFinal == null ? DateTime.MaxValue : paginacaoRequest.DatavalidadeFinal;
        }
    }
}
