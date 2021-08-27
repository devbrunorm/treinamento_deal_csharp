using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Diretorio
{
    class Arquivo
    {
        private static string CaminhoArquivo(int numeroArquivo) 
        {
            return ConfigurationManager.AppSettings["caminhoArquivos"] + "arq" + numeroArquivo + ".txt";
        }
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = CaminhoArquivo(numeroArquivo);
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    };
                }
            }
            string arquivoComCaminho2 = CaminhoArquivo(numeroArquivo + 1);
            if (File.Exists(arquivoComCaminho2))
            {
                Ler(numeroArquivo + 1);
            }
        }
    }
}
