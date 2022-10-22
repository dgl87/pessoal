using System;

namespace _01_EstCondIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor que você possui na conta poupança: ");
            float valorPoupanca = float.Parse(Console.ReadLine());
            if (valorPoupanca > 100000)
            {
                Console.WriteLine("Você possui uma taxa diferenciada!");
            }
            else if (valorPoupanca > 50000)
            {
                Console.WriteLine("Você é um cliente especial, com taxas de juros de 1,2% ao mês");
            }
            else
            {
                Console.WriteLine("Você é um cliente especial, mas sua taxa de juros é de 0,5% ao mês");
            }
        }
    }
}
