using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Conversao(double cotacao, double dolares)
        {
            double valor = cotacao * dolares;
            return valor + valor * Iof / 100.00;
        }
    }

}
