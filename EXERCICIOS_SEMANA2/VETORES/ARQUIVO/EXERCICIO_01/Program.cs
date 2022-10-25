using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Arquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            int laco = 0;
            string email;
            string nomeArquivo;
            Console.WriteLine("Sistema de Cadastramento de E-mail.\n");
            Console.WriteLine("Digite o nome do Arquivo: ");
            nomeArquivo = Console.ReadLine();
            Classe_Email a = new Classe_Email(nomeArquivo);
            while(laco == 0)
            {
                Console.WriteLine("Digite uma Operação.\n1 - Cadastrar Email\n2 - Listar Email\n3 - Sair");
                op = int.Parse(Console.ReadLine());
                if(op == 1)
                {
                    a.criaAbreArquivo();
                    Console.WriteLine("\nDigite o email a ser cadastrado:");
                    email = Console.ReadLine();
                    a.gravaEmail(email);
                    a.fechaArquivo();
                }
                else if(op == 2){
                    a.listarEmail();
                }
                else
                {
                    a.fechaArquivo();
                    laco = 1;
                }
            }
        }
    }
}
