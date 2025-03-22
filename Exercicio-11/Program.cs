using Biblioteca;

namespace Exercicio_11;
internal class Program
{
    //11. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
    //Considere sempre anos completos, e que um ano possui 365 dias.Ex: uma pessoa com 19 anos possui 6935 dias
    //de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
    static void Main(string[] args)
    {
        Console.Title = "Dias de vida";
        do
        {
            Metodos.Titulo("          Dias de vida ");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {
            Console.WriteLine();
            Console.Write("-> Digite o nome da pessoa: ");
            string nome = Metodos.NomeValido();

            Console.Write("-> Digite a idade da pessoa: ");
            int idade = Metodos.ValorValidoInt();

            while (idade < 1)
            {
                Console.WriteLine(" -> (X) A idade precisa ser maior que 1.");
                Console.WriteLine(" -> Informe a idade novamente: ");
                Console.Write("-> Digite a idade da pessoa: ");
                idade = Metodos.ValorValidoInt();
            }

            int diasDeVida = idade * 365;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" Formula: ");
            Console.WriteLine();
            Console.WriteLine(" -> Dias de vida = idade x 365");
            Console.WriteLine();
            Console.WriteLine(" Solução:");
            Console.WriteLine();
            Console.WriteLine($" -> Dias de vida = {idade} x 365");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"-> {nome}, você tem {idade} e já viveu {diasDeVida} dias!");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
