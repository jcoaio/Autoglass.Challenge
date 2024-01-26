using Autoglass.Challenge.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Autoglass.Challenge.DTOs
{
    public class ProdutoInsertRequest
    {
        [Required(ErrorMessage = "Informe a descrição do produto.")]
        [StringLength(50, ErrorMessage = "A descrição do produto deve ter até 50 caracteres.")]
        public string Descricao { get; set; }
        public SituacaoProduto? Situacao { get; set; } = SituacaoProduto.Ativo;
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }

        [Required(ErrorMessage ="Informe o fornecedor do produto.")]
        public int IdFornecedor { get; set; }
    }
}
