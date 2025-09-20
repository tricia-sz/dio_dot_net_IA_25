namespace ExemploFundamentos.Models
{
  public class Pessoa
  {
    public string Nome { get; set; } 
    public int Idade { get; set; }
    public string NomeRepresentanteLegalDaPessoaFisica { get; set; } 
    

    public void Apresentar()
    {

      Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos");
    }
  }
}