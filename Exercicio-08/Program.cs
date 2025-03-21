using Biblioteca;

namespace Exercicio_08
{
    internal class Program
    {
        //8. Crie um programa para verificar se um número é primo.
        static void Main(string[] args)
        {
            Console.Title = "Verificador de número primo";
            do
            {
                Metodos.Titulo("    Verificador de número primo");
                Operacao();
            } while (Metodos.Continuar());

            static void Operacao()
            {

                Console.Write("-> Digite um número: ");
                int numero = Metodos.ValorValidoInt();

                while (numero <= 0)
                {
                    Console.WriteLine(" -> (X) O número deve ser maior que zero.");
                    Console.Write("-> Digite um número novamente: ");
                    numero = Metodos.ValorValidoInt();
                }

                if (numero % numero == 0 && numero % 1 == 0)
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine($"-> O número {numero} é primo.");
                    Console.WriteLine("-------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine($"-> O número {numero} > NÃO < é primo.");
                    Console.WriteLine("-------------------------------------------------------");
                }
            }
        }
    }
}
