using System;

namespace _01Conceitos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Douglas";
            obj.idade = 35;

            obj.Mensagem();
        }
    }
}