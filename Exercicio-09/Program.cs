using Biblioteca;

namespace Exercicio_09;
// 9. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
//terreno e depois exibir a área do terreno.
internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Área do terreno";
        do
        {
            Metodos.Titulo("Calculadora de área de terreno retangular");
            Operacao();
        } while (Metodos.Continuar());
    }

    static void Operacao()
    {
        Console.WriteLine(" * Vamos digitar as dimensões do terreno ");

        Console.Write("-> Digite a largura do terreno(m): ");
        double largura = Metodos.ValorValidoDouble();

        Console.Write("-> Digite o comprimento do terreno(m): ");
        double comprimento = Metodos.ValorValidoDouble();

        while (largura <= 0 || comprimento <= 0)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(" -> (X) Os valores devem ser maiores que 0.");
            Console.WriteLine("-------------------------------------------");
            Console.Write("-> Digite a largura do terreno novamente: ");
            largura = Metodos.ValorValidoDouble();

            Console.Write("-> Digite o comprimento do terreno novamente: ");
            comprimento = Metodos.ValorValidoDouble();
                        
        }

        double area = largura * comprimento;

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine(" Formula: ");
        Console.WriteLine();
        Console.WriteLine(" -> Área = largura x comprimento");
        Console.WriteLine();
        Console.WriteLine(" Solução:");
        Console.WriteLine();
        Console.WriteLine($" -> Área = {largura} x {comprimento}");
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine($" -> A área do terreno é: {area} m².");
        Console.WriteLine("-------------------------------------------------------");

    }
}
