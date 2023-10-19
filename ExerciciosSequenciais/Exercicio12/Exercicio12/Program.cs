namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90,
            escreva um algoritmo para ler a marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia,
            o número de litros de combustível gasto e o valor total (R$) recebido dos passageiros. Calcule e escreva a média do consumo
            em Km/l e o lucro líquido do dia.*/

            Console.Write("Digite a marcação do odômetro no início do dia (em Km): ");
            double initialOdometer = double.Parse(Console.ReadLine());

            Console.Write("Digite a marcação do odômetro no final do dia (em Km): ");
            double finalOdometer = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de litros de combustível gasto: ");
            double litersFuel = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor total recebido dos passageiros (em R$): ");
            double totalAmountReceived = double.Parse(Console.ReadLine());

            double distanceTraveled = finalOdometer - initialOdometer;
            double avarageConsumption = distanceTraveled / litersFuel;
            double profitByDay = totalAmountReceived - (litersFuel * 6.90);

            Console.WriteLine();
            Console.WriteLine($"Quilometragem total: {distanceTraveled:F2} Km");
            Console.WriteLine($"Média de consumo: {avarageConsumption:F2} Km/l");
            Console.WriteLine($"Lucro líquido do dia: R${profitByDay:F2}");

            Console.ReadLine();
        }
    }
}