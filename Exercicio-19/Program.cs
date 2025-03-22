using Biblioteca;

namespace Exercicio_19;

internal class Program
{
    //19. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
    //encontram no conjunto dos números de 1 até 500.
    static void Main(string[] args)
    {
        Console.Title = "Soma de números ímpares";
        Metodos.Titulo(" Soma de números ímpares entre 1 e 500");
        Operacao();

        static void Operacao()
        {
            int soma = 0;
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"-> A Soma dos números ímpares múltiplos de 3 é: {soma}.");
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
