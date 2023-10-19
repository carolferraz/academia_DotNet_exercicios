namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            Console.Write("Insira o primeiro número: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Insira o terceiro número: ");
            double number3 = double.Parse(Console.ReadLine());

            Console.Write("Insira o quarto número: ");
            double number4 = double.Parse(Console.ReadLine());

            double avarage = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine("A média entre " + number1 + ", " + number2 + ", " + number3 + " e " + number4 + " é: " + avarage);

            Console.ReadLine();
        }
    }
}