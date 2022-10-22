using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo, tecle enter para continuar");
            Console.ReadLine();

            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            int n = int.Parse(Console.ReadLine());

        






            Console.WriteLine();
            if (n < 12)
            {
                Console.WriteLine($"Olá {nome}, você é um grandessissimo BABA OVO!!!");
                Console.WriteLine($"Você é um bebê ainda! tem {n} anos e é nutela!");
                Console.WriteLine("####################################################");

            }
            else if (n < 35)
                Console.WriteLine($"Oi {nome}, Você é um garotão! , só tem {n} de idade!! Bonito! Charmoso!");
            else
            {
                Console.WriteLine("####################################################");
                Console.WriteLine($"Olá {nome}, você é uma grandessissima BABA OVO MEU OVO!!!");
                Console.WriteLine($"Você tem {n} anos!! Você já é idosa!!!");
                Console.WriteLine("####################################################");

                Console.Beep();
            }

        }
    }
}
