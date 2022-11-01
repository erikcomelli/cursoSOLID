using Ex4_Resolucao;

IPromocao promocao = new PromocaoDiaMaes();
Produto produto = new Produto(promocao);
produto.Nome = "Celular";
produto.Preco = 1000;
Console.WriteLine($"Nome do produto: {produto.Nome}");
Console.WriteLine($"Preço após promoção: {produto.PrecoVenda()}");

IPromocao promocao2 = new PromocaoDiaNamorados();
Produto produto2 = new Produto(promocao2);
produto.Nome = "Perfume";
produto.Preco = 500;
Console.WriteLine($"Nome do produto: {produto.Nome}");
Console.WriteLine($"Preço após promoção: {produto.PrecoVenda()}");

Console.ReadLine();
