using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    internal class Teste
    {
        public void MostraLinhasUsandoUsing()
        {
            //Mostra linhas utilizando using para fechar stream
            string path = @"C:\temp\file1.txt";

            try
            {
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
