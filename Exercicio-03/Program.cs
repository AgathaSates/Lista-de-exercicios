using Biblioteca;

namespace Exercicio_03;

internal class Program
{ //3. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.
  // O programa deve solicitar ao usuário:
  //● A quilometragem inicial do veículo no início da viagem.
  //● A quilometragem final ao término da viagem.
  //● A quantidade de combustível consumida durante a viagem(em litros).
    static void Main(string[] args)
    {
        Console.Title = "Consumo de combustível por quilômetro percorrido";
        do{
            Metodos.Titulo("        Consumo de combustível");
            Operacao();
        } while (Metodos.Continuar());
        
        static void Operacao() 
        {
            double kmInicial;
            double kmFinal;

            Console.Write("-> Digite a quilometragem inicial: ");
            kmInicial = Metodos.ValorValidoDouble();

            Console.Write("-> Digite a quilometragem final: ");
            kmFinal = Metodos.ValorValidoDouble();

            while (kmFinal <= kmInicial)
            {
                Console.WriteLine(" -> (X) A quilometragem final deve ser maior que a inicial.");
                Console.Write("-> Digite a quilometragem final novamente: ");
                kmFinal = Metodos.ValorValidoDouble();
            }

            Console.Write("-> Digite o consumo de combustível após a viagem (litros): ");
            double consumo = Metodos.ValorValidoDouble();

            double distanciaPercorrida = kmFinal - kmInicial;

            double consumoPorKm = consumo / distanciaPercorrida;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" Formula: ");
            Console.WriteLine();
            Console.WriteLine(" -> Distância percorrida = KM Final - KM Inicial");
            Console.WriteLine($" -> Consumo por KM = distância percorrida ÷ consumo do combustível");
            Console.WriteLine();
            Console.WriteLine(" Solução:");
            Console.WriteLine();
            Console.WriteLine($" -> Distância percorrida = {kmFinal} - {kmInicial}");
            Console.WriteLine($" -> Consumo por KM = {consumo} ÷ {distanciaPercorrida}");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($" -> O consumo de combustível foi de: {consumoPorKm:F4} L/KM.");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
