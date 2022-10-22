using System.Globalization;

namespace CSharpCompleto
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porc)
        {
            SalarioBruto += (SalarioBruto * porc) / 100.0;
        }
        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
