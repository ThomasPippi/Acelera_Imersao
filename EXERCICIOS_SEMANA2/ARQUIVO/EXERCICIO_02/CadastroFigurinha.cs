using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Figurinha_Copa
{
    internal class CadastroFigurinha
    {
        StreamWriter sw;
        StreamReader sr;

        public void fechaArquivo()
        {
            sw.Close();
        }
        public void criaAbreArquivoFaltante()
        {
            sw = new StreamWriter("C:\\Arquivo\\faltante.csv", true, Encoding.UTF8);
        }
        public void criaAbreArquivoRepetida()
        {
            sw = new StreamWriter("C:\\Arquivo\\repetidas.csv", true, Encoding.UTF8);
        }
        public void cadastraFaltante(string codigoFiruginha, string selecaoFigurinha, string jogadorFigurinha)
        {
            sw.WriteLine(codigoFiruginha + ";" + selecaoFigurinha + ";" + jogadorFigurinha);
        }
        public void cadastraRepetida(string codigoFiruginha, string selecaoFigurinha, string jogadorFigurinha)
        {
            sw.WriteLine(codigoFiruginha + ";" + selecaoFigurinha + ";" + jogadorFigurinha);
        }
        public void listarRepetida()
        {
            string linha;
            sr = new StreamReader("C:\\Arquivo\\repetidas.csv");
            linha = sr.ReadLine();
            while(linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }
        public void listarFaltante()
        {
            string linha;
            sr = new StreamReader("C:\\Arquivo\\faltante.csv");
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
