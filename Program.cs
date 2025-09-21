using ExemploFundamentos.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
  Console.WriteLine("Venda inválida. Quantidade: 0");
}
else if (possivelVenda)
{
  Console.WriteLine("Venda realizada com sucesso.");
}
else
{
  Console.WriteLine("Desculpe. Nao temos a quantidade desejada em estoque.");
  
}