using System;

namespace _07Construtor
{
    internal class Pessoa
    {
        // Construtor
        public Pessoa()
        {
            Console.WriteLine("Construtor executado");
        }
        public Pessoa(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }
    }
}
