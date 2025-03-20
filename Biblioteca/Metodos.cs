namespace Biblioteca
{
    public class Metodos
    {
        public static double ValorValidoDouble()
        {
            double medida;
            while (!double.TryParse(Console.ReadLine(), out medida))
            {
                Console.Write(" -> (X) Valor inválido! Digite novamente: ");
            }
            return medida;
        }
        public static bool Continuar()
        {
            Console.Write("Deseja continuar? (S/N) ");
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
