using System.Runtime.Intrinsics.Arm;
using Biblioteca;

namespace Exercicio_23;

internal class Program
{
    //23. Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
    //múltiplos de 3 pela palavra "Fizz" e os múltiplos de 5 pela palavra "Buzz". Para números que são múltiplos de
    //ambos, use "FizzBuzz".
    static void Main(string[] args)
    {
        Console.Title = "FizzBuzz";

        Metodos.Titulo("              FizzBuzz ");
        Console.WriteLine("- De 1 a 100 \n- Os números múltiplos de 3 são exibidos pela palavra >Fizz< \n- Os múltiplos de 5 pela palavra >Buzz<  \n- Os que são múltiplos de ambos é exibido a palavra >FizzBuzz<");
        Operacao();


        static void Operacao()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("- FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("- Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("- Buzz");
                }
                else
                {
                    Console.WriteLine($"- {i}");
                }
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
