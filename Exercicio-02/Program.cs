using Biblioteca;

namespace Exercicio_02;

internal class Program
{
    //2. Crie um programa para calcular o volume de um Cilindro.
    static void Main(string[] args)
    {
        Console.Title = "Volume de um Cilindro";
        do { 
            Metodos.Titulo("Calcule o volume de um cilindro");
            Operacao();
        } while (Metodos.Continuar());
    }
    static void Operacao()
    {
        Console.Write("-> Digite o raio do cilindro: ");
        double raio = Metodos.ValorValidoDouble();
        Console.Write("-> Digite a altura do cilindro: ");
        double altura = Metodos.ValorValidoDouble();
        double resultado = Math.PI * Math.Pow(raio, 2) * altura;
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($" -> O volume do cilindro é de {resultado:F2} cm³.");
        Console.WriteLine("----------------------------------------------");
    }
}
