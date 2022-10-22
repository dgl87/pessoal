using System;
using System.Collections.Generic;

namespace ProgramacaoOrientadaObjeto
{
    public class Professor : Pessoa
    {
        public List<string> Turmas { get; private set; }
        public double Salario { get; private set; }

        public Professor(string nome, string documento, DateTime dataNascimento, float salario) : base(nome, documento, dataNascimento)
        {
            Salario = salario;
            Turmas = new List<string> { "A", "B" };
        }
        public override void Apresentacao()
        {
            base.Apresentacao();
            string turmas = string.Join(", ", Turmas);
            Console.WriteLine($"Meu salário é {Salario:F2} e ensino para as turmas {turmas}");
        }
    }
}
