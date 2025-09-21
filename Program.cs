using ExemploFundamentos.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;


Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if (possivelVenda)
{
  Console.WriteLine("Venda realizada com sucesso.");
}
else
{
  Console.WriteLine("Desculpe. Nao temos a quantidade desejada em estoque.");
  
}