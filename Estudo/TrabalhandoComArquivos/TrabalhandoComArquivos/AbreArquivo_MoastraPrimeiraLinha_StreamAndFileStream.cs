using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    public class AbreArquivo_MoastraPrimeiraLinha_StreamAndFileStream
    {
        public void MostraLinhaTerminal()
        {
            //Abre arquivo e mostra a primeira linha no terminal
            string path = @"C:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //abre arquivo para acesso
                fs = new FileStream(path, FileMode.Open);
                //Conseguimos fazer uma leitura do arquivo
                sr = new StreamReader(fs);
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
                if (fs != null) fs.Close();
            }
        }

    }
}
