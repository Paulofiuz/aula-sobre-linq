using LINQ;

Console.Clear();

var listaDeProdutos = Produto.ObterProdutos();


var produtosCarosComEstoque = listaDeProdutos.Where(p => p.Preco >= 200 && p.Estoque > 4);

System.Console.WriteLine("");

foreach (var item in produtosCarosComEstoque)
{
    System.Console.WriteLine($"Item: {item.Nome}, Preço: {item.Preco}");
}

System.Console.WriteLine("");

var produtosEletronicos = listaDeProdutos.Where(p => p.Categoria == "Eletrodomésticos");
foreach (var item in produtosEletronicos)
{
    System.Console.WriteLine($"Item: {item.Nome}, Preço: {item.Preco}");
}

System.Console.WriteLine("");
int minimo = 10;
var estoqueMinimo = listaDeProdutos.Where(p => p.Estoque < minimo).OrderBy(p => p.Nome);

foreach (var item in estoqueMinimo)
{
    System.Console.WriteLine($"Item: {item.Nome}, Preço: {item.Preco}");
}

System.Console.WriteLine("Produto ordenado por categoria e nomes: ");
var ordenadoPorCategoria = listaDeProdutos.OrderBy
                                                  (p => p.Categoria)
                                                  .ThenBy(p => p.Nome);

string? categoriAnterio = "";
foreach (var item in ordenadoPorCategoria)
{
    if (item.Categoria != categoriAnterio)
    {
        System.Console.WriteLine($"         {item.Categoria}: ");
        categoriAnterio = item.Categoria;
    }
    System.Console.WriteLine($"     {item.Nome}");
}

var nomesDosProdutos = listaDeProdutos.Select(p => p.Nome).OrderBy(nome => nome);
foreach (var item in nomesDosProdutos)
{
    System.Console.WriteLine(item);
}

var resultado = listaDeProdutos.Where(p => p.Preco < 500).
                                                        OrderBy(p => p.Nome)
                                                        .Select(p => new 
                                                        {
                                                            nomeProduto = p.Nome.ToUpper(),
                                                            precoComAumento = p.Preco * 1.1
                                                        });

foreach (var item in resultado)
{
    System.Console.WriteLine($"{item.nomeProduto} preço com aumento {item.precoComAumento:C}");
}