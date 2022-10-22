using System;

namespace ProgramacaoOrientadaObjeto
{
    public abstract class Pessoa
    {
        public string Nome { get; protected set; }
        public string Documento { get; protected set; }
        public DateTime DataNascimento { get; protected set; }

        public Pessoa(string nome, string documento, DateTime dataNascimento)
        {
            Nome = nome;
            Documento = documento;
            DataNascimento = dataNascimento;
        }

        public virtual void Apresentacao()
        {
            Console.WriteLine($"Ola {Nome}, seu documento é {Documento} e sua data de nascimento é {DataNascimento}");
        }
    }
}
