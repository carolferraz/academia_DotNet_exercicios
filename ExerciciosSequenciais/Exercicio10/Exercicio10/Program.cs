namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
            para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
            realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
            notas de menor valor fossem distribuídas em número mínimo possível. 
            Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
            Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
            de acordo com o critério da “distribuição ótima”.
            */

            Console.Write("Digite o valor da quantia solicitada: R$");
            double quantiaSolicitada = double.Parse(Console.ReadLine());

            if (quantiaSolicitada <= 0)
            {
                Console.WriteLine("A quantia solicitada deve ser maior que zero.");
            }
            else
            {
                DistribuirNotas(quantiaSolicitada);
            }

            Console.ReadLine();
        }

            static void DistribuirNotas(double quantia)
            {
                int[] notas = { 50, 20, 10, 5, 1 };

                Console.WriteLine("Distribuição ótima de notas:");

                for (int i = 0; i < notas.Length; i++)
                {
                    int quantidadeNotas = (int)(quantia / notas[i]);
                    quantia %= notas[i];

                    if (quantidadeNotas > 0)
                    {
                        Console.WriteLine($"Notas de R${notas[i]:F2}: {quantidadeNotas}");
                    }
                }
            }
    }
}