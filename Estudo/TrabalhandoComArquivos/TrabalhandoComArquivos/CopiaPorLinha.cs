using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    public class CopiaPorLinha
    {
        //Copia o conteudo de um documento existente no caminho c:\temp\file1.txt para um novo arquivo informado na variável target
        public void CopiaArquivoPorLinhaParaOutro()
        {
            //Localização do arquivo existente
            string sourcePath = @"C:\temp\file1.txt";

            //Localização da gravação do novo arquivo
            string targetPath = @"C:\temp\file2.txt";

            string[] lines = File.ReadAllLines(sourcePath);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            try
            {
                //mostra onde está o arquivo que será copiado
                FileInfo fileInfo = new FileInfo(sourcePath);
                //mostra onde será gravado
                fileInfo.CopyTo(targetPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
