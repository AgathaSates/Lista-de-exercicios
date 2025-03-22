using Biblioteca;

namespace Exercicio_22;

internal class Program
{
    //22. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
    static void Main(string[] args)
    {
        Console.Title = "Fibonacci";
        do
        {
            Metodos.Titulo("          Fibonacci ");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {
            Console.Write("Digite um numero: ");
            int numero = Metodos.ValorValidoInt();
            while (numero < 1)
            {
                Console.WriteLine(" -> (X) O número deve ser maior que 0.");
                Console.Write("Digite um número novamente: ");
                numero = Metodos.ValorValidoInt();
            }

            int primeirovalor = 0;
            int segundovalor = 1;
            int soma = 0;
            string sequencia = "";

            for (int i = 1; i < numero; i++)
            {
                soma = primeirovalor + segundovalor;

                sequencia += $",{soma}";
                
                primeirovalor = segundovalor ;
                segundovalor = soma;
 
            }
            Console.WriteLine($"1{sequencia}.");
        }
    }
}
