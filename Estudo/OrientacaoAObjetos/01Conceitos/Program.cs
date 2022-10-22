using System;

namespace _01Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar
            Pessoa obj = new Pessoa();
            obj.nome = "Douglas";
            obj.idade = 35;

            obj.Mensagem();

        }
    }
}
