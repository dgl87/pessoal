using System;

namespace _06Encapsulamento
{
    internal class Aluno
    {
        // Atributos
        private double nota1, nota2;

        // Média
        private double Media()
        {
            return (nota1 + nota2) / 2;
        }

        //Mensagem
        public void Mensagem()
        {
            Console.Write("Informe a primeira nota: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A média é " + Media());
        }
    }
}
