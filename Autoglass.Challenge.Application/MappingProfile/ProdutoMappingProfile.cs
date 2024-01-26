using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.Domain.Parameters;
using Autoglass.Challenge.DTOs;
using AutoMapper;

namespace Autoglass.Challenge.Application.MappingProfile
{
    public class ProdutoMappingProfile : Profile
    {
        public ProdutoMappingProfile()
        {
            CreateMap<ProdutoInsertRequest, Produto>();

            CreateMap<ProdutoUpdateRequest, Produto>();

            CreateMap<Produto, ProdutoResponse>().ForMember(d => d.Situacao, s => s.MapFrom(p => p.Situacao.ToString()));

            CreateMap<ProdutoPaginacaoRequest, ProdutosParameters>();
        }
    }
}
