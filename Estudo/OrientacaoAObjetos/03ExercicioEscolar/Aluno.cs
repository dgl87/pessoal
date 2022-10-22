using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ExercicioEscolar
{
    internal class Aluno
    {
        // Atributos
        public string nome;
        public double nota1, nota2;

        // Métodos
        // Média
        public double Media()
        {
            return (nota1 + nota2) / 2;
        }

        //Situação
        //Mensagem

    }
}
