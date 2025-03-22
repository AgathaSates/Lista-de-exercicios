using Biblioteca;

namespace Exercicio_12;
internal class Program
{
   // 12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
   //impostos.Imprima o salário inicial, o salário com o aumento e o salário final.
    static void Main(string[] args)
    {
        Console.Title = "Aumento de salário";
        do
        {
            Metodos.Titulo("          Aumento de salário ");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {            
            Console.Write("-> Digite o salário do funcionário: ");
            double salario = Metodos.ValorValidoDouble();
            while (salario <= 0)
            {
                Console.Write(" -> (X) O Valor precisa ser maior que 0 digite novamente: ");
                salario = Metodos.ValorValidoDouble();
            }

            double aumento = salario * 0.15;
            double salarioAumento = salario + aumento;
            double salarioFinal = salarioAumento - (salarioAumento * 0.08);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"-> Salário inicial: R$ {salario:F2}");
            Console.WriteLine($"-> Salário com aumento de 15%: R$ {salarioAumento:F2}");
            Console.WriteLine($"-> Salário final: R$ {salarioFinal:F2}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
