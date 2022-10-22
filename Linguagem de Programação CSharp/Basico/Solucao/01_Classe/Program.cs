using System;

namespace _01_Classe.Veiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            Console.WriteLine("Marca: " + carro1.marca);
            carro1.marca = "Ford";
            Console.WriteLine("Marca: " + carro1.marca);

            Console.WriteLine("Luzes internas " + carro1.luzesInternas);
            carro1.AbrirPorta();
            Console.WriteLine("Luzes internas " + carro1.luzesInternas);

            string statusFarol = carro1.AcenderFarolAutomaticamente();
            Console.WriteLine("Status do farol: " + statusFarol);
        }
    }
}
