using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Application.MappingProfile
{
    public class FornecedorMappingProfile : Profile
    {
        public FornecedorMappingProfile()
        {
            CreateMap<Fornecedor, FornecedorResponse>();
        }
    }
}
