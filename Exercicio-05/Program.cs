using Biblioteca;

namespace Exercicio_05;

internal class Program
{
    // 5. Crie um programa para calcular o salário total de um vendedor.Deverá ser informado o salário base e o total de
    //vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
    static void Main(string[] args)
    {
        Console.Title = "Calculo de salário de um vendedor";
        do
        {
            Metodos.Titulo("    Calculo de salário de um vendedor");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {
            double salarioBase;
            double totalVendas;
            double percentual;


            Metodos.Titulo("    Calculo de salário de um vendedor");

            Console.Write("-> Digite o salário base: ");
            salarioBase = Metodos.ValorValidoDouble();
            while (salarioBase <= 0)
            {
                Console.WriteLine(" -> (X) O salário deve ser maior que zero.");
                Console.Write("-> Digite o salário base novamente: ");
                salarioBase = Metodos.ValorValidoDouble();
            }

            Console.Write("-> Digite o total de vendas: ");
            totalVendas = Metodos.ValorValidoDouble();

            Console.Write("-> Digite a porcentagem de comissão: ");
            percentual = Metodos.ValorValidoDouble();

            while (percentual <= 0)
            {
                Console.WriteLine(" -> (X) A porcentagem de comissão deve ser maior que zero.");
                Console.Write("-> Digite a porcentagem de comissão novamente: ");
                percentual = Metodos.ValorValidoDouble();
            }

            double comissao = totalVendas * (percentual / 100);
            double salarioTotal = salarioBase + comissao;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" Formula: ");
            Console.WriteLine();
            Console.WriteLine(" -> Comissão = total de vendas x (percentual  ÷ 100)");
            Console.WriteLine(" -> Salário total = salário base + comissão");
            Console.WriteLine();
            Console.WriteLine(" Solução:");
            Console.WriteLine();
            Console.WriteLine($" -> Comissão = {totalVendas} x ({percentual} ÷ 100)");
            Console.WriteLine($" -> Salário total = {salarioBase} + {comissao}");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($" -> O salário do vendedor será de R$ {salarioTotal:F2}.");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
