using System.Collections.Generic;

namespace Autoglass.Challenge.DTOs
{
    public class ProdutoPaginacaoResponse
    {
        public IEnumerable<ProdutoResponse> Produtos { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public int Count { get; set; }
    }
}
