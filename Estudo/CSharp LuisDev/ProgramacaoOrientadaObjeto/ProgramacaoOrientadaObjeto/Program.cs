using System;
using System.Collections.Generic;

namespace ProgramacaoOrientadaObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor("Cristina", "09876543210", new DateTime(1983, 05, 15), 1500);
            Estudante estudante = new Estudante("Douglas", "12365478909", new DateTime(1987, 04, 07), "A");

            List<Pessoa> pessoas = new List<Pessoa> { estudante, professor };

            foreach (Pessoa item in pessoas)
            {
                item.Apresentacao();
            }

            Console.ReadKey();
        }
    }
}
