using System.Globalization;
using System.Xml.Linq;

namespace Biblioteca
{
    public class Metodos
    {
        public static void Titulo(string titulo)
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($" {titulo}");
            Console.WriteLine("------------------------------------------");
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

        public static string NomeValido()
        {
            string nome;
            while (true)
            {                                                //  A-l-e-x-a-n-d-r-e R-e-c-h 
                nome = Console.ReadLine()!;          //Se tiver um caractere que não seja letra nem espaço,o nome é invalido, tipo: alexandre1?#                           
                if (string.IsNullOrWhiteSpace(nome) || !nome.All(c => char.IsLetter(c) || c == ' ') || nome.Length < 3 || nome.Length > 30)
                {                                           //"c" é o nome de cada      |ou se o caractere 
                                                            //caractere da string       |é espaço

                                                      // .all para conferir se {nome} atende todas as condições

                    Console.Write(" -> (X) Nome inválido! Digite novamente: ");                  
                }
                else
                    break;
            }

            nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome); //transforma a primeira letra de cada palavra em maiúsculo:
            // alexrande rech -> Alexandre Rech 
            return nome;
        }

    }
}
