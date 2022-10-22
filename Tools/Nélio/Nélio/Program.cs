using System;
using System.Globalization;

namespace Nélio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] p = new Produto[n];
            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Produto(nome, preco);
                soma += p[i].Preco;
            }

            double media = soma / n;
            Console.WriteLine($"AVERAGE PRICE = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
