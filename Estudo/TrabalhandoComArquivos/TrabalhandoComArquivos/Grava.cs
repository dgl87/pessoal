using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    public class Grava
    {

        public void WriterDoc()
        {
            string path = @"C:\temp\file1.txt";

            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Douglas André");
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
