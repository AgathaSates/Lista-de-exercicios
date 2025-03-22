using Biblioteca;

namespace Exercicio_07;

internal class Program
{
    //7. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
    static void Main(string[] args)
    {
        Console.Title = "Média Ponderada";
        do{
            Metodos.Titulo("           Média Ponderada");
            Operacao();
        }
        while (Metodos.Continuar());

        static void Operacao() 
        {
            Console.Write("-> Digite a nota da 1° prova: ");
            double nota1 = Metodos.ValorValidoDouble();

            Console.Write("-> Digite o peso desta nota: ");
            double peso1 = Metodos.ValorValidoDouble();

            while (peso1 <= 0 || nota1 <= 0)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(" -> (X) O peso e a nota devem ser maiores que zero.");
                Console.WriteLine(" -> Informe os valores novamente:");
                Console.WriteLine("----------------------------------------------------");
                Console.Write("-> Digite a nota da 1° prova: ");
                nota1 = Metodos.ValorValidoDouble();

                Console.Write("-> Digite o peso desta nota: ");
                peso1 = Metodos.ValorValidoDouble();
            }

            Console.Write("-> Digite a nota da 2° prova: ");
            double nota2 = Metodos.ValorValidoDouble();

            Console.Write("-> Digite o peso desta nota: ");
            double peso2 = Metodos.ValorValidoDouble();

            while (nota2 <= 0 || peso2 <= 0)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(" -> (X) O peso e a nota devem ser maiores que zero.");
                Console.WriteLine(" -> Informe os valores novamente:");
                Console.WriteLine("----------------------------------------------------");
                Console.Write("-> Digite a nota da 2° prova: ");
                nota2 = Metodos.ValorValidoDouble();
                Console.Write("-> Digite o peso desta nota: ");
                peso2 = Metodos.ValorValidoDouble();
            }

            double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" Formula: ");
            Console.WriteLine();
            Console.WriteLine(" -> Média Ponderada = (nota x peso + nota x peso) ÷ (peso + peso)");
            Console.WriteLine();
            Console.WriteLine(" Solução:");
            Console.WriteLine();
            Console.WriteLine($" -> Média Ponderada = ({nota1} x {peso1} + {nota2} x {peso2}) ÷ ({peso1} + {peso2})");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($" -> A Média Ponderada do aluno é: {mediaPonderada:F2}.");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
