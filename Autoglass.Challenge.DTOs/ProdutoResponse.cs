using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.Domain.Enums;
using System;

namespace Autoglass.Challenge.DTOs
{
    public class ProdutoResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Situacao { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public FornecedorResponse Fornecedor { get; set; }
    }
}
