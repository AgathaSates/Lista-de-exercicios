using Biblioteca;

namespace Exercicio_15;
internal class Program
{
    //15. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
    // a condição de peso de uma pessoa adulta.A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
    // peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
    //● IMC em adultos Condição
    //● Abaixo de 18,5
    //● Abaixo do peso
    //● Entre 18,5 e 25 Peso normal
    //● Entre 25 e 30
    //● Acima do peso
    //● Acima de 30 obeso
    static void Main(string[] args)
    {
        Console.Title = "IMC";
        do
        {
            Metodos.Titulo("                 IMC ");
            Operacao();
        } while (Metodos.Continuar());

        static void Operacao()
        {

            Console.Write("-> Digite o peso do adulto: ");
            double peso = Metodos.ValorValidoDouble();

            Console.Write("-> Digite a altura do adulto: ");
            double altura = Metodos.ValorValidoDouble();

            while (peso <= 0 || altura <= 0)
            {
                Console.WriteLine(" -> (X) Os valores precisam ser maiores que 0.");
                Console.WriteLine(" -> Informe os valores novamente:");
                Console.Write("-> Digite o peso do adulto: ");
                peso = Metodos.ValorValidoDouble();

                Console.Write("-> Digite a altura do adulto: ");
                altura = Metodos.ValorValidoDouble();
            }

            double imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"IMC: {imc:F2} - Abaixo do peso.");
                Console.WriteLine("----------------------------------");

            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($" IMC: {imc:F2} - Normal.");
                Console.WriteLine("----------------------------------");

            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($" IMC: {imc:F2} - Acima do peso.");
                Console.WriteLine("----------------------------------");

            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"IMC: {imc:F2} - Obesidade grau 1.");
                Console.WriteLine("----------------------------------");

            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"IMC: {imc:F2} - Obesidade grau 2.");
                Console.WriteLine("----------------------------------");

            }
            else if (imc >= 40)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"IMC: {imc:F2} - Obesidade grau 3.");
                Console.WriteLine("----------------------------------");

            }
        }
    }
}
