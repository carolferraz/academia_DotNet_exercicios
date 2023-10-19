namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. 
            Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.*/

            Console.Write("Digite o número de eleitores: ");
            int totalVoters = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos brancos: ");
            int blankVotes = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos nulos: ");
            int nullVotes = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos válidos: ");
            int validVotes = int.Parse(Console.ReadLine());

            double percentBlankVotes = (double)blankVotes / totalVoters * 100;
            double percentNullVotes = (double)nullVotes / totalVoters * 100;
            double percentValidVotes = (double)validVotes / totalVoters * 100;

            Console.WriteLine($"Percentual de votos em branco: {percentBlankVotes:F2}%");
            Console.WriteLine($"Percentual de votos nulos: {percentNullVotes:F2}%");
            Console.WriteLine($"Percentual de votos válidos: {percentValidVotes:F2}%");
            Console.ReadLine();
        }
    }
}