using Biblioteca;
namespace Exercicio_04;

internal class Program
{
    //4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit.
    static void Main(string[] args)
    {
        Console.Title = "Conversor de temperatura";
        do{
            Metodos.Titulo("        Conversor de temperatura");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao() 
        {
            Console.Write("-> Digite a temperatura em Celsius a ser convertido para Fahrenheit:");
            double celsius = Metodos.ValorValidoDouble();

        }
    }
}
