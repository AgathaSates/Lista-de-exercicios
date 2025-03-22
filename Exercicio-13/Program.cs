using Biblioteca;

namespace Exercicio_13;

internal class Program
{
    //13. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
    static void Main(string[] args)
    {
        Console.Title = "Soma de A + B é menor que C?";
        do
        {
            Metodos.Titulo("          Soma de A + B é menor que C?");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao() 
        {
            Console.Write("-> Digite o valor de A: ");
            double a = Metodos.ValorValidoDouble();

            Console.Write("-> Digite o valor de B: ");
            double b = Metodos.ValorValidoDouble();

            Console.Write("-> Digite o valor de C: ");
            double c = Metodos.ValorValidoDouble();

            double soma = a + b;
            
            if (soma < c)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($" -> A soma de A + B é: {soma}.");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($" -> O valor de C é: {c}.");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-> A soma de A + B é menor que C!");
                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($" -> A soma de A + B é: {soma}");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($" -> O valor de C é: {c}");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"-> A soma de A + B >NÂO< é menor que C!");
                Console.WriteLine("-------------------------------------");

            }

        }
    }
}
