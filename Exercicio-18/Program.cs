using Biblioteca;

namespace Exercicio_18;

internal class Program
{
    //18. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
    static void Main(string[] args)
    {
        Console.Title = "Números ímpares";

        Metodos.Titulo("   Números ímpares entre 100 e 200 ");
        Operacao();

        static void Operacao()
        {
            Console.WriteLine("Lista dos números");
            Console.WriteLine("------------------");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine($"- {i}");

            }
            Console.WriteLine("------------------");

        }
    }
}
