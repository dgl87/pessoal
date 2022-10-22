using System;

namespace _01Conceitos
{
    internal class Pessoa
    {
        // Atributos
        public string nome;
        public int idade;

        // Métodos / Funções
        public void Mensagem()
        {
            Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos");
        }

    }
}
