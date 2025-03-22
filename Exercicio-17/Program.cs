using Biblioteca;

namespace Exercicio_17;

internal class Program
{
    //17. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
    //contrário multiplique A por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
    //variável C e mostrar seu conteúdo na tela.
    static void Main(string[] args)
    {
        Console.Title = "Soma ou multiplicação";
        do
        {
            Metodos.Titulo("          Soma ou multiplicação ");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {
            Console.WriteLine("Se os valores forem iguais será somado senão multiplicados.");
            Console.WriteLine();

            Console.Write("-> Digite o valor de A: ");
            int a = Metodos.ValorValidoInt();

            Console.Write("-> Digite o valor de B: ");
            int b = Metodos.ValorValidoInt();

            int c = a == b ? a + b : a * b;

            Console.WriteLine("----------------------");
            Console.WriteLine($"-> Valor de A: {a}");
            Console.WriteLine($"-> Valor de B: {b}");
            Console.WriteLine("----------------------");
            Console.WriteLine($"-> O Resultado da operação é: {c}");
            Console.WriteLine("----------------------");
        }
    }
}
