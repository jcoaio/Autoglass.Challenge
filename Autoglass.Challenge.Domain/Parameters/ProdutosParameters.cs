using Autoglass.Challenge.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Domain.Parameters
{
    public class ProdutosParameters
    {
        public SituacaoProduto? Situacao { get; set; }
        public DateTime DataFabricacaoInicial { get; set; }
        public DateTime DataFabricacaoFinal { get; set; }
        public DateTime DatavalidadeInicial { get; set; }
        public DateTime DatavalidadeFinal { get; set; }

        public int Skip { get; set; }
        public int Take { get; set; } = 5;
    }
}
