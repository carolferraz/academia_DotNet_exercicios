namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel (medido em Km/ l),
            //sendo que são conhecidos a distância total percorrida e o volume de combustível consumido para percorrê-la(medido em l).

            Console.Write("Digite a distância total percorrida (em km): ");
            double travelledDistance = double.Parse(Console.ReadLine());

            Console.Write("Digite o volume de combustível consumido (em litros): ");
            double fuelVolume= double.Parse(Console.ReadLine());

            double avarageConsumption = travelledDistance / fuelVolume;

            Console.WriteLine($"O consumo médio do automóvel é de {avarageConsumption} Km/l");
            Console.ReadLine();
        }
    }
}