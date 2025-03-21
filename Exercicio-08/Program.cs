using Biblioteca;

namespace Exercicio_08;

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

            while (numero <= 1)
            {
                Console.WriteLine(" -> (X) O número deve ser maior que 1.");
                Console.Write("-> Digite um número novamente: ");
                numero = Metodos.ValorValidoInt();
            }

            bool primo = true;
                                              // confere entre 2 e -1 do {numero} para saber se ele tem mais que 2 divisores.
            for (int i = 2; i < numero; i++) // i = 2 pq 1 divide qualquer número./ testa se o {numero} é divisível por i.
            {      // se for <= {numero}, ele entraria no if, e resultaria em false pq todos os numeros são divisíveis por ele mesmo. 
                if (numero % i == 0) // Se o resto da divisão for 0, o {numero} foi dividido por outro q n seja 1 ou ele.
                {
                    primo = false;
                    break;
                }
            }

            if (!primo)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"-> O número {numero} > NÃO < é primo.");
                Console.WriteLine("-------------------------------------------------------");
            }
            else 
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"-> O número {numero} é primo.");
                Console.WriteLine("-------------------------------------------------------");
            }
        }
    }
}
