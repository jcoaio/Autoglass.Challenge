using Autoglass.Challenge.Domain.Enums;
using System;

namespace Autoglass.Challenge.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public SituacaoProduto? Situacao { get; set; } = SituacaoProduto.Ativo;
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int IdFornecedor { get; set; }
    }
}
