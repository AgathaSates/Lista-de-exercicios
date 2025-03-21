using Biblioteca;
namespace Exercicio_10;

internal class Program
{
    //10. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.Cada
    //pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
    //venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
    //Você foi contratado para fazer os cálculos para o dono.Com base nestes fatos, faça um algoritmo para ler as
    //quantidades de pães e de broas, e depois calcular os dados solicitados.

    static void Main(string[] args)
    {
        Console.Title = " Vendas da padaria ";
        do
        {
            Metodos.Titulo("          Vendas da padaria ");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {
            Console.Write("-> Digite a quantidade de pães vendidos: ");
            int paes = Metodos.ValorValidoInt();

            while (paes < 0)
            {
                Console.WriteLine(" -> (X) A quantidade de pães não pode ser negativa.");
                Console.WriteLine(" -> Informe a quantidade novamente: ");
                Console.Write("-> Digite a quantidade de pães vendidos: ");
                paes = Metodos.ValorValidoInt();
            }

            Console.Write("-> Digite a quantidade de broas vendidas: ");
            int broas = Metodos.ValorValidoInt();

            while (broas < 0)
            {
                Console.WriteLine(" -> (X) A quantidade de broas não pode ser negativa.");
                Console.WriteLine(" -> Informe a quantidade novamente: ");
                Console.Write("-> Digite a quantidade de broas vendidos: ");
                broas = Metodos.ValorValidoInt();

            }

            while (broas <= 0 && paes <= 0)
            {
                Console.WriteLine(" -> (X) A quantidade de broas ou pães deve ser maior que zero.");
                Console.WriteLine(" -> Informe as quantidades novamente: ");

                Console.Write("-> Digite a quantidade de pães vendidos: ");
                 paes = Metodos.ValorValidoInt();

                Console.Write("-> Digite a quantidade de broas vendidas: ");
                 broas = Metodos.ValorValidoInt();
            }

            double totalPao = paes * 0.12;
            double totalBroa = broas * 1.50;
            double totalVendas = totalPao + totalBroa;
            double poupanca = totalVendas * 0.10;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"-> O total de vendas de pães foi: R${totalPao}.");
            Console.WriteLine($"-> O total de vendas de broas foi: R${totalBroa}.");
            Console.WriteLine($"-> O total de vendas de pães e broas foi: R${totalVendas}.");
            Console.WriteLine($"-> O valor para guardar na poupança é: R${poupanca:F2}.");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
