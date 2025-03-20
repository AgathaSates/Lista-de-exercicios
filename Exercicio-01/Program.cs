using Biblioteca;
namespace Exercicio_01;

internal class Program
{ // 1. Crie um programa para calcular o volume de uma caixa retangular.
    static void Main(string[] args)
    {
        Console.Title = "Volume de uma caixa retangular";
        do {
            Metodos.Titulo("Calcule o volume de uma caixa retangular");
            Operacao();
        } while (Metodos.Continuar());

    }
    
    ////////////////////////////////////////////////////////////////////
   
    static void Operacao() 
    {
        Console.Write("-> Digite o comprimento da caixa: ");
        double comprimento = Metodos.ValorValidoDouble();

        Console.Write("-> Digite a largura da caixa: ");
        double largura = Metodos.ValorValidoDouble();

        Console.Write("-> Digite a altura da caixa: ");
        double altura = Metodos.ValorValidoDouble();

        double resultado = comprimento * largura * altura;
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($" -> O volume da caixa é de {resultado} cm³.");
        Console.WriteLine("----------------------------------------------");
    }       
}
