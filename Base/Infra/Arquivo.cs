﻿using System;
using System.IO;
using System.Text;

namespace Infra
{
    public static class Arquivo
    {
        public static void GravarTextoNoFinalDoArquivo(string _texto, string _arquivo)
        {
            FileStream fileStream = new FileStream(_arquivo, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);

            streamWriter.WriteLine(_texto);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();

        }

        public static void GravarLog(string _texto)
        {
            GravarTextoNoFinalDoArquivo(DateTime.Now.ToString() + _texto, Constantes.DiretorioLog + 
                "\\" + Constantes.NomeArquivoLog);
        }
      
    }
}
