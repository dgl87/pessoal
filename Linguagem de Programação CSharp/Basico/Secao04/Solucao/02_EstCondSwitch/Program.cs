using System;

namespace _02_EstCondSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu estado civil: " +
                "\nS = Solteiro " +
                "\nC = Casado " +
                "\nV = Viuvo " +
                "\nD = Divorciado");

            string resp = Console.ReadLine();
            switch (resp)
            {
                case "S":
                    Console.WriteLine("Procure alguém na rede social");
                    break;
                case "C":
                    Console.WriteLine("Você deve cuidar bem da sua família");
                    break;
                case "V":
                    Console.WriteLine("Você deve recomeçar");
                    break;
                case "D":
                    Console.WriteLine("Não deu certo, tente de novo");
                    break;
                default:
                    Console.WriteLine("Comando não reconhecido");
                    break;
            }
        }
    }
}
