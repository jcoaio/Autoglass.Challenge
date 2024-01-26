using Autoglass.Challenge.Domain.Enums;
using System;

namespace Autoglass.Challenge.DTOs
{
    public class ProdutoPaginacaoRequest
    {
        public SituacaoProduto? Situacao { get; set; }
        public DateTime? DataFabricacaoInicial { get; set; }
        public DateTime? DataFabricacaoFinal { get; set; }
        public DateTime? DatavalidadeInicial { get; set; }
        public DateTime? DatavalidadeFinal { get; set; }

        public int Skip { get; set; }
        public int Take { get; set; } = 5;
    }
}
