using System.Globalization;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, isto é, o código,
            //a quantidade de peças e o valor unitário de cada parafuso e a porcentagem de IPI (única) a ser acrescentada. 

            // Parafuso A
            Console.WriteLine("Dados do Parafuso A:");
            Console.Write("Código: ");
            string codeA = Console.ReadLine();
            Console.Write("Quantidade de peças: ");
            int quantityA = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário: ");
            double unitaryPriceA = double.Parse(Console.ReadLine());
            Console.Write("Porcentagem de IPI: ");
            int ipiA = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Parafuso B
            Console.WriteLine("Dados do Parafuso B:");
            Console.Write("Código: ");
            string codeB = Console.ReadLine();
            Console.Write("Quantidade de peças: ");
            int quantityB = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário: ");
            double unitaryPriceB = double.Parse(Console.ReadLine());
            Console.Write("Porcentagem de IPI: ");
            int ipiB = int.Parse(Console.ReadLine());

            double totalA = CalculateTotal(quantityA, unitaryPriceA, ipiA);
            double totalB = CalculateTotal(quantityB, unitaryPriceB, ipiB);

            Console.WriteLine();
            PrintResults(codeA, quantityA, unitaryPriceA, ipiA, totalA);
            PrintResults(codeB, quantityB, unitaryPriceB, ipiB, totalB);
            Console.ReadLine();
        }

        private static double CalculateTotal(int quantity, double unitaryPrice, int ipiPorcentage)
        {
            double total = quantity * unitaryPrice * (1 + (ipiPorcentage / 100));
            return total;
        }

        private static void PrintResults(string code, int quantity, double unitaryPrice, int ipi, double total)
        {
            Console.WriteLine($"Resultado para o Parafuso {code}");
            Console.WriteLine($"Quantidade de peças: {quantity}");
            Console.WriteLine($"Valor unitário: R${unitaryPrice.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Porcentagem de IPI: {ipi.ToString("F2", CultureInfo.InvariantCulture)}%");
            Console.WriteLine($"Valor total com IPI: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}