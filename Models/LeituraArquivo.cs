using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace CSharpFS.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeDeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }

        }
    }
}