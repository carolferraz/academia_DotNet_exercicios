namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio,
            //para trocar entre si os valores de duas variáveis A e B.
            int a = 10;
            int b = 20;

            Console.WriteLine($"Valores iniciais: A = {a}, B = {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Valores após a troca: A = {a}, B = {b}");
            Console.ReadLine();
        }
    }
}