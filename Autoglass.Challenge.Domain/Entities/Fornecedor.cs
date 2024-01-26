using System.Collections.Generic;

namespace Autoglass.Challenge.Domain.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Cnpj { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
