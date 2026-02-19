ProdutoFisico item1 = new ProdutoFisico("Camiseta", "Camiseta de algodão", 29.99m, "camiseta.jpg");

Console.WriteLine($@"Dados do item 1:
Nome: {item1.Nome};
Descrição: {item1.Descricao};
Preço: {item1.Preco};
Estoque: {item1.Estoque}.
");

Console.WriteLine($"Imagem: {item1.Imagem}");
item1.Imagem = "camiseta2.jpg";
Console.WriteLine($"Imagem: {item1.Imagem}");

item1.Avaliar(10, "Excelente!");

Console.WriteLine($@"Dados do item 1:
Nome: {item1.Nome};
Descrição: {item1.Descricao};
Preço: {item1.Preco};
Estoque: {item1.Estoque}.
Nota: {item1.Avaliacao.Nota}
Comentario: {item1.Avaliacao.Comentario}
");

ProdutoDigital item2 = new ProdutoDigital("Curso", "Dev em C#", 129.99m, "imagem_ilustrativa.jpg", "link de compra");

Console.WriteLine($@"Dados do item 2:
Nome: {item2.Nome};
Descrição: {item2.Descricao};
Preço: {item2.Preco};
Link: {item2.LinkDownload};
Está expirado: {item2.EstaExpirado()}.
");


Pedido pedido = new Pedido(1, "João", 159.98m);
pedido.ExibirResumo();


