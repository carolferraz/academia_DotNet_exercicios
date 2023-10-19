using System.Globalization;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
             ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
             Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
             se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
             Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
             da entrada e das duas prestações, de acordo com as regras acima. 
             Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
             conseqüente pagamento dos boletos das duas prestações.
             */
            Console.Write("Digite o valor da mercadoria: R$");
            double valorMercadoria = double.Parse(Console.ReadLine());

            if (valorMercadoria <= 0)
            {
                Console.WriteLine("O valor da mercadoria deve ser maior que zero.");
            }
            else
            {
                double entrada, prestacao1, prestacao2;

                if (valorMercadoria % 3 == 0)
                {
                    entrada = valorMercadoria / 3;
                    prestacao1 = entrada;
                    prestacao2 = entrada;
                }
                else
                {
                    prestacao1 = Math.Floor(valorMercadoria / 3);
                    prestacao2 = Math.Floor(valorMercadoria / 3);
                    entrada = valorMercadoria - prestacao1 - prestacao2;
                }

                Console.WriteLine($"Valor da entrada: R${entrada.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Valor da 1ª prestação: R${prestacao1.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Valor da 2ª prestação: R${prestacao2.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.ReadLine();
        }
    }
}