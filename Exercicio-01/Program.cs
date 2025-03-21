using Biblioteca;

namespace Exercicio_01;

internal class Program
{ // 1. Crie um programa para calcular o volume de uma caixa retangular.
    static void Main(string[] args)
    {
        Console.Title = "Volume de uma caixa retangular";
        do
        {
            Metodos.Titulo("    Volume de uma caixa retangular");
            Operacao();
        } while (Metodos.Continuar());

    }
   
    static void Operacao() 
    {
        double comprimento;
        double largura;
        double altura;

        Console.Write("-> Digite o comprimento da caixa: ");
        comprimento = Metodos.ValorValidoDouble();

        while (comprimento <= 0)
        {
            Console.WriteLine(" -> (X) O comprimento deve ser maior que zero.");
            Console.Write("-> Digite o comprimento da caixa novamente: ");
            comprimento = Metodos.ValorValidoDouble();
        }

        Console.Write("-> Digite a largura da caixa: ");
        largura = Metodos.ValorValidoDouble();

        while (largura <= 0)
        {
            Console.WriteLine(" -> (X) A largura deve ser maior que zero.");
            Console.Write("-> Digite a largura da caixa novamente: ");
            largura = Metodos.ValorValidoDouble();
        }

        Console.Write("-> Digite a altura da caixa: ");
        altura = Metodos.ValorValidoDouble();

        while (altura <= 0)
        {
            Console.WriteLine(" -> (X) A altura deve ser maior que zero.");
            Console.Write("-> Digite a altura da caixa novamente: ");
            altura = Metodos.ValorValidoDouble();
        }
        
        double resultado = comprimento * largura * altura;

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine(" Formula: ");
        Console.WriteLine(" -> Volume = comprimento x largura x altura");
        Console.WriteLine(" Solução:");
        Console.WriteLine($" -> Volume = {comprimento} x {largura} x {altura} ");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($" -> Resultado: O volume da caixa é de {resultado:F2} cm³.");
        Console.WriteLine("------------------------------------------------");
    }       
}
