using Biblioteca;

namespace Exercicio_14; 
internal class Program
{
    //14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
    static void Main(string[] args)
    {
        Console.Title = "Ordem decrescente";
        do
        {
            Metodos.Titulo("          Ordem decrescente ");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {
            int[] valores = new int[3];


            Console.Write("-> Digite o primeiro valor: ");
            int a = Metodos.ValorValidoInt();

            Console.Write("-> Digite o segundo valor: ");
            int b = Metodos.ValorValidoInt();

            while (b == a)
            {
                Console.WriteLine(" -> (X) O segundo valor não pode ser igual ao primeiro.");
                Console.WriteLine(" -> Informe o segundo valor novamente: ");
                Console.Write("-> Digite o segundo valor: ");
                b = Metodos.ValorValidoInt();
            }

            Console.Write("-> Digite o terceiro valor: ");
            int c = Metodos.ValorValidoInt();           

            while (c == a || c == b)
            {
                Console.WriteLine(" -> (X) O terceiro valor não pode ser igual aos anteriores.");
                Console.WriteLine(" -> Informe o terceiro valor novamente: ");
                Console.Write("-> Digite o terceiro valor: ");
                c = Metodos.ValorValidoInt();
            }

            valores[0] = a;
            valores[1] = b;
            valores[2] = c;

            Array.Sort(valores);
            Array.Reverse(valores);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"-> Os valores em ordem decrescente são: {valores[0]}, {valores[1]} e {valores[2]}.");
            Console.WriteLine("-------------------------------------------------------");

        }
    }
}
