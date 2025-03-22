using Biblioteca;

namespace Exercicio_16;

internal class Program
{
    //  16. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
    static void Main(string[] args)
    {
        Console.Title = "Par ou ímpar";
        do
        {
            Metodos.Titulo("          Par ou ímpar ");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {
            Console.Write("-> Digite um número: ");
            int numero = Metodos.ValorValidoInt();
            
            if (numero % 2 == 0)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"-> O número {numero} é par.");
                Console.WriteLine("----------------------");

            }
            else
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"-> O número {numero} é ímpar.");
                Console.WriteLine("----------------------");

            }
        }
    }
}
