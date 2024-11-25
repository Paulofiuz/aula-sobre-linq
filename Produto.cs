namespace LINQ
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public string? Categoria { get; set; }

        public static List<Produto> ObterProdutos()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto { Id = 1, Nome = "Notebook", Preco = 5000, Categoria = "Informática", Estoque = 20 },
                new Produto { Id = 2, Nome = "PC Gamer", Preco = 6000, Categoria = "Informática", Estoque = 15 },
                new Produto { Id = 3, Nome = "Mouse", Preco = 120, Categoria = "Informática", Estoque = 50 },
                new Produto { Id = 4, Nome = "Teclado Mecânico", Preco = 350, Categoria = "Informática", Estoque = 30 },
                new Produto { Id = 5, Nome = "Onix", Preco = 100000, Categoria = "Automóveis", Estoque = 40 },
                new Produto { Id = 6, Nome = "Civic", Preco = 150000, Categoria = "Automóveis", Estoque = 25 },
                new Produto { Id = 7, Nome = "Celular", Preco = 1500, Categoria = "Eletrônicos", Estoque = 39 },
                new Produto { Id = 8, Nome = "Tablet", Preco = 2000, Categoria = "Eletrônicos", Estoque = 22 },
                new Produto { Id = 9, Nome = "Smart TV", Preco = 3500, Categoria = "Eletrônicos", Estoque = 18 },
                new Produto { Id = 10, Nome = "Geladeira", Preco = 2800, Categoria = "Eletrodomésticos", Estoque = 12 },
                new Produto { Id = 11, Nome = "Micro-ondas", Preco = 800, Categoria = "Eletrodomésticos", Estoque = 14 },
                new Produto { Id = 12, Nome = "Ventilador", Preco = 200, Categoria = "Eletrodomésticos", Estoque = 45 }
            };
            return produtos;
        }
    }
}
