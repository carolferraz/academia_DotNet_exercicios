using System.Globalization;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas.
            //Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.


            Console.Write("Digite o número do vendedor: ");
            int sellerNumber = int.Parse(Console.ReadLine());

            Console.Write("Digite o salário fixo do vendedor: R$");
            double fixedSalary = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas efetuadas pelo vendedor: R$");
            double totalSales = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual que o vendedor ganha sobre as vendas (%): ");
            double salesPercentage = double.Parse(Console.ReadLine());


            double commission = (salesPercentage / 100) * totalSales;
            double totalSalary = fixedSalary + commission;

            Console.WriteLine();
            Console.WriteLine($"Número do vendedor: {sellerNumber}");
            Console.WriteLine($"Salário total do vendedor: R${totalSalary.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }
}