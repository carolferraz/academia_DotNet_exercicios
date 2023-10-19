namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
            Console.Write("Insira o primeiro número: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            double number2 = double.Parse(Console.ReadLine());

            double avarage = (number1 + number2) / 2;

            Console.WriteLine("A média entre " + number1 + " e " + number2 + " é: " + avarage);

            Console.ReadLine();
        }
    }
}