using System.Globalization;

namespace Biblioteca
{
    public class Metodos
    {
        public static double ValorValidoDouble()
        {
            double medidaValida;
                      
            while(true)
            {
                string medida = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(medida) || !double.TryParse(medida.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out medidaValida))
                {
                    Console.Write(" -> (X) Valor inválido! Digite novamente: ");
                }
                else
                    break;
            }
            return medidaValida;
        }
        public static int ValorValidoInt()
        {
            int medidaValida;
            while (true)
            {
                string medida = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(medida) || !int.TryParse(medida, out medidaValida))
                {
                    Console.Write(" -> (X) Valor inválido! Digite novamente: ");
                }
                else
                    break;
            }
            return medidaValida;
        }

        public static bool Continuar()
        {
            Console.Write("Deseja efetuar outro calculo? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();
            while (string.IsNullOrWhiteSpace(opcaoContinuar) || opcaoContinuar.ToUpper() != "S" && opcaoContinuar.ToUpper() != "N")
            {
                Console.Write(" -> (X) Opção inválida! Digite novamente: ");
                opcaoContinuar = Console.ReadLine()!;
            }
            if (opcaoContinuar == "N")
                return false;
            else return true;
        }

        public static void Titulo(string titulo)
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($" {titulo}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
