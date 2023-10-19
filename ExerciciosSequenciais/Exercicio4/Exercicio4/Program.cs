namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            //forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
            Console.Write("Digite a data no formato DDMMAAAA: ");
            string inputDate = Console.ReadLine();

            if (inputDate.Length != 8)
            {
                Console.WriteLine("Formato de data inválido. Certifique-se de inserir 8 dígitos (DDMMAAAA).");
            }
            else
            {
                string day = inputDate.Substring(0, 2);
                string month = inputDate.Substring(2, 2);
                string year = inputDate.Substring(4, 4);

                string dateAAAAMMDD = year + month + day;
                string dateAAMMDD = year.Substring(2, 2) + month + day;

                Console.WriteLine($"Data no formato AAAAMMDD: {dateAAAAMMDD}");
                Console.WriteLine($"Data no formato AAMMDD: {dateAAMMDD}");
            }

            Console.ReadLine();
        }
    }
}