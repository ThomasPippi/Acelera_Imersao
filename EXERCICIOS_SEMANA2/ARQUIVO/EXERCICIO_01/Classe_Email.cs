using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Arquivo
{
    internal class Classe_Email
    {
        string nomeArquivo;
        StreamWriter sw;
        StreamReader sr;
        public Classe_Email(string nomeArquivo) {
            this.nomeArquivo = nomeArquivo;
        }

        public void criaAbreArquivo()
        {
            sw = new StreamWriter("C:\\Arquivo\\" + nomeArquivo + ".txt", true, Encoding.UTF8);
        }

        public void listarEmail()
        {
            string linha;
            sr = new StreamReader("C:\\Arquivo\\" + nomeArquivo + ".txt");
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }

        public void gravaEmail(string email)
        {
            sw.WriteLine(email);
        }

        public void fechaArquivo(){
            sw.Close();
            }
    }
}
