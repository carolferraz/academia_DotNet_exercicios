namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais,
            mais uma comissão de 15% sobre o preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do 
            salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas vendidas pelo vendedor, calcule e mostre: 
            o salário do empregado*/

            Console.Write("Digite o valor do salário mínimo mensal: R$");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço de custo de cada bicicleta: R$");
            double precoCustoBicicleta = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
            int bicicletasVendidas = int.Parse(Console.ReadLine());

            double salarioVendedor = 2 * salarioMinimo + (0.15 * precoCustoBicicleta * bicicletasVendidas);

            Console.WriteLine($"O salário do empregado é: R${salarioVendedor:F2}");

            Console.ReadLine();


        }
    }
}