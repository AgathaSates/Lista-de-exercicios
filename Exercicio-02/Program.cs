using Biblioteca;

namespace Exercicio_02;

internal class Program
{
    //2. Crie um programa para calcular o volume de um Cilindro.
    static void Main(string[] args)
    {
        Console.Title = "Volume de um Cilindro";
        do{
            Metodos.Titulo("        Volume de um cilindro");
            Operacao();
        } while (Metodos.Continuar());
    }
    static void Operacao()
    {
        double raio;
        double altura;

        Console.Write("-> Digite o raio do cilindro: ");
        raio = Metodos.ValorValidoDouble();

        while (raio <= 0)
        {
            Console.WriteLine(" -> (X) O raio deve ser maior que zero.");
            Console.Write("-> Digite o raio do cilindro novamente: ");
            raio = Metodos.ValorValidoDouble();

        }

        Console.Write("-> Digite a altura do cilindro: ");
        altura = Metodos.ValorValidoDouble();

        while (altura <= 0)
        {
            Console.WriteLine(" -> (X) A altura deve ser maior que zero.");
            Console.Write("-> Digite a altura do cilindro novamente: ");
            altura = Metodos.ValorValidoDouble();

        }

        double resultado = Math.PI * Math.Pow(raio, 2) * altura;

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine(" Formula: ");
        Console.WriteLine(" -> Volume = PI × raio² × altura ");
        Console.WriteLine(" Solução:");
        Console.WriteLine($" -> Volume = {Math.PI:f2} x {raio}² x {altura} ");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine($" -> O volume do cilindro é de {resultado:F2} unidades cúbicas.");
        Console.WriteLine("-----------------------------------------------------");
    }
}
