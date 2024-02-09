namespace Doador.Domain.Entities
{
    internal class Produto
    {
        public class Produtos
        {
            public int ProdutoId { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public string Categoria { get; set; }
            public string NomeDoador { get; set; }
            public string DisponibilidadeDoacao { get; set; }

        }

    }
}
