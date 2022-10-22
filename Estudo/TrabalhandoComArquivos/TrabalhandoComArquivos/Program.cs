using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Copia o conteúdo de um arquivo para um novo arquivo
            //var copia = new CopiaArquivo();
            //copia.CopiaArquivoParaOutro();

            ////Copia o conteúdo de um arquivo para um novo arquivo e mostra linha por linha no terminal
            //var copiaPorLinha = new CopiaPorLinha();
            //copiaPorLinha.CopiaArquivoPorLinhaParaOutro();

            ////Utilizando Stream e FileStream, abre arquivo e mostra a primeira linha, forma extendida
            //var mostraLinhaComFileStream = new AbreArquivo_MoastraPrimeiraLinha_StreamAndFileStream();
            //mostraLinhaComFileStream.MostraLinhaTerminal();

            ////Utilizando Stream e FileStream, abre arquivo e mostra a primeira linha, forma compacta
            //var mostraLinhaComFileStreamCompacto = new AbreArquivo_MoastraPrimeiraLinha_StreamAndFileStream_Compacto();
            //mostraLinhaComFileStreamCompacto.MostraLinhaTerminal();

            ////Utilizando Stream e FileStream, abre arquivo e mostra todas linhas, forma compacta
            //var mostraTodasLinhasComFileStreamCompacto = new AbreArquivo_MoastraTodasLinhasStreamAndFileStream_Compacto();
            //mostraTodasLinhasComFileStreamCompacto.MostraTodasLinhasTerminal();

            ////Utilizando Stream e FileStream, abre arquivo e mostra todas linhas, forma compacta
            //var mostraTodasLinhasComFileStreamCompactoUsing = new AbreArquivo_MostraLinhas_UsandoUsing();
            //mostraTodasLinhasComFileStreamCompactoUsing.MostraLinhasUsandoUsing();

            ////Utilizando StreamWriter, abre arquivo e grava linha por linha em maiusculo em outro arquivo
            //var gravaLinhaNoutroArquivo = new CopiaLinhaPorLinhaParaOutroArquivoUsandoStreamWriter();
            //gravaLinhaNoutroArquivo.WriterDoc();

            //Utilizando StreamWriter, abre arquivo e grava linha por linha em maiusculo em outro arquivo
            var test = new Grava();
            test.WriterDoc();
        }
    }
}
