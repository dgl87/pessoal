using System;

namespace _02_Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro.QuantidadeCarrosProduzidos = 2000000000;
            Carro carro1 = new Carro();
            carro1.AbrirPorta();
            Console.WriteLine("Hello World!");
        }
    }
}
