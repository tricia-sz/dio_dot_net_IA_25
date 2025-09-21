using ExemploFundamentos.Models;

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
  Console.WriteLine("Vogal");
}
else
{
  Console.WriteLine("Não é uma vogal");
  
}