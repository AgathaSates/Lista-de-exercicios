using Biblioteca;

namespace Exercicio_06;
internal class Program
{
    //6. Crie um programa para calcular a média harmônica das notas de um Aluno.
    static void Main(string[] args)
    {
        Console.Title = "Média Harmônica";
        do{
            Metodos.Titulo("           Média Harmônica");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {
            double quantidadeNotas;
            double nota = 0;
            double somaNotas = 0;
            double notaDividida = 0;

            Console.Write("-> Digite a quantidade de notas que irá calcular: ");
            quantidadeNotas = Metodos.ValorValidoDouble();
            while (quantidadeNotas <= 0)
            {
                Console.WriteLine(" -> (X) A quantidade de notas deve ser maior que zero.");
                Console.Write("-> Digite a quantidade de notas novamente: ");
                quantidadeNotas = Metodos.ValorValidoDouble();
            }

            for (int i = 1; i <= quantidadeNotas; i++)
            {
                Console.Write($"-> Digite a {i}ª nota: ");
                nota = Metodos.ValorValidoDouble();
                while (nota <= 0)
                {
                    Console.WriteLine(" -> (X) A nota deve ser maior que zero.");
                    Console.Write($"-> Digite a {i}ª nota novamente: ");
                    nota = Metodos.ValorValidoDouble();
                }

                notaDividida = 1 / nota;
                somaNotas += notaDividida;
            }

            double mediaHarmonica = quantidadeNotas / somaNotas;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" Formula: ");
            Console.WriteLine();
            Console.WriteLine(" -> Média Harmônica = quantidade de notas ÷ soma das notas");
            Console.WriteLine(" -> Soma das notas = 1 ÷ cada nota");
            Console.WriteLine();
            Console.WriteLine(" Solução:");
            Console.WriteLine();
            Console.WriteLine($" -> Media Harmonica = {quantidadeNotas} ÷ {somaNotas:F2}");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($" -> A Média harmonica do aluno é: {mediaHarmonica:F2}.");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
