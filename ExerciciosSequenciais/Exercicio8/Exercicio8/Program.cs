namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit:F2} °F");

            Console.ReadLine();
        }
    }
}