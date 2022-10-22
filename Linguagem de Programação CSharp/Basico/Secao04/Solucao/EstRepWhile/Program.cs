using System;

namespace EstRepWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Número: " + (i + 1));
                i++;
            }

            int x = 0;
            bool repetir = true;

            while (repetir)
            {
                Console.WriteLine("Valor da variável x: " + x);
                if (x > 20)
                {
                    Console.WriteLine("Saindo do programa");
                    repetir = false;
                }
                x++;
            }
        }
    }
}
