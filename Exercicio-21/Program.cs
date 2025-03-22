using Biblioteca;

namespace Exercicio_21;

internal class Program
{
    //Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
    //a.Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
    //b.Pesquise sobre “fatorial”
    static void Main(string[] args)
    {
        Console.Title = "Fatorial";
        do
        {
            Metodos.Titulo("          Fatorial ");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {
            Console.Write("Digite um número para calcular o fatorial: ");
            int a = Metodos.ValorValidoInt();

            while (a < 0)
            {

                Console.WriteLine(" -> (X) O número deve ser maior que 0.");
                Console.Write("Digite um número para calcular o fatorial: ");
                a = Metodos.ValorValidoInt();
            }

            int fatorial = 1;
            string sequencia ="";

            for (int i = a; i >= 1; i--)
            {
                fatorial *= i;
                sequencia += (i == 1) ? $" {i}" : $" {i} x";

            }
            Console.WriteLine($"{a}! = {sequencia} = {fatorial}");

        }
    }
}
