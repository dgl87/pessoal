using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    public class AbreArquivo_MoastraPrimeiraLinha_StreamAndFileStream_Compacto
    {
        public void MostraLinhaTerminal()
        {
            //Abre arquivo e mostra a primeira linha no terminal
            string path = @"C:\temp\file1.txt";            
            StreamReader sr = null;
            try
            {
                //Conseguimos fazer uma leitura do arquivo
                sr = File.OpenText(path);
                //Lê uma linha do arquivo e guarda na variável line
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                //Fecha streamer dando certo ou não
                if (sr != null) sr.Close();
            }
        }
    }
}
