using Biblioteca;

namespace Exercicio_20;

internal class Program
{
    //20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N.

    static void Main(string[] args)
    {
        Console.Title = "Tabuada";
        do
        {
            Metodos.Titulo("               Tabuada ");
            Operacao();
        } while (Metodos.Continuar());
    }

    static void Operacao()
    {
        Console.Write("Digite um número de 1 a 10: ");
        double n = Metodos.ValorValidoDouble();
        while (n < 1 || n > 10)
        {
            Console.Write(" -> (X) Valor inválido! Digite novamente: ");
            n = Metodos.ValorValidoDouble();
        }
        Console.Clear();
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"         Tabuada do {n}");
        Console.WriteLine("--------------------------------");

        for (double contador = 1; contador <= 10; contador++)
        {
            double resultadoTabuada = n * contador;
            Console.WriteLine($" {n} x {contador} = {resultadoTabuada}");
        }
        Console.WriteLine("--------------------------------");
    }
}
