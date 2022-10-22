using System;

namespace _04ExercicioIMC
{
    public class Pessoa
    {
        public double peso;
        public double altura;

        public double RetornaIMC()
        {
            return peso / (altura * altura);
        }

        public string RetornaSituacao(double imc)
        {
            string stringImc;
            if (imc < 18.5)
                stringImc = $"IMC: {imc.ToString("F2")}\t-\tSituação: Abaixo do peso";
            else if (imc < 25)
                stringImc = $"IMC: {imc.ToString("F2")}\t-\tSituação: Peso Normal";
            else if (imc < 30)
                stringImc = $"IMC: {imc.ToString("F2")}\t-\tSituação: Acima do peso";
            else if (imc < 35)
                stringImc = $"IMC: {imc.ToString("F2")}\t-\tSituação: Obesidade I";
            else if (imc < 40)
                stringImc = $"IMC: {imc.ToString("F2")}\t-\tSituação: Obesidade II";
            else
                stringImc = $"IMC: {imc.ToString("F2")}\t-\tSituação: Obesidade III";

            return stringImc;
        }

        public void ExibeSituacao()
        {
            double respImc = RetornaIMC();

            string respSituacao = RetornaSituacao(respImc);

            Console.WriteLine(respSituacao);
        }
    }
}
