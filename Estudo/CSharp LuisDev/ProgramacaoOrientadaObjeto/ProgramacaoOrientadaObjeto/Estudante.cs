using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramacaoOrientadaObjeto
{
    public class Estudante : Pessoa
    {
        public string Turma { get; set; }
        public List<int> Notas { get; set; }

        public Estudante(string nome, string documento, DateTime dataNascimento, string turma) : base(nome, documento, dataNascimento)
        {
            Turma = turma;
            Notas = new List<int> { 5, 10, 4, 2, 3, 5 };
        }
        public override void Apresentacao()
        {
            base.Apresentacao();

            var media = Notas.Average();
            Console.WriteLine($"Sou um estudante da turma {Turma} e a minha média é {media:F2}");
        }
    }
}
