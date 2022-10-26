using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurinha_Copa
{
    internal class Figurinha
    {
        static void Main(string[] args)
        {
            int op = 0, laco = 0;
            string codigoFigurinha, selecaoFigurinha, jogadorFigurinha;             
            CadastroFigurinha cadastro = new CadastroFigurinha();
            Console.WriteLine("\nMenu de Interação.");
            while(laco == 0)
            {
                Console.WriteLine("1 - Cadastrar figurinha FALTANTE.\n" +
                    "2 - Cadastrar figurinha REPETIDA.\n" +
                    "3 - Listar figurinhas REPETIDAS.\n" +
                    "4 - Listar figurinhas FALTANTES.\n" +
                    "5 - SAIR");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        cadastro.criaAbreArquivoFaltante();
                        Console.WriteLine("Digite o código da figurinha: ");
                        codigoFigurinha = Console.ReadLine();
                        Console.WriteLine("Digite a Seleção do jogador: ");
                        selecaoFigurinha = Console.ReadLine();
                        Console.WriteLine("Digite o jogador da figurinha: ");
                        jogadorFigurinha = Console.ReadLine();
                        cadastro.cadastraFaltante(codigoFigurinha, selecaoFigurinha, jogadorFigurinha);
                        cadastro.fechaArquivo();
                        break;
                    case 2:
                        cadastro.criaAbreArquivoRepetida();
                        Console.WriteLine("Digite o código da figurinha: ");
                        codigoFigurinha = Console.ReadLine();
                        Console.WriteLine("Digite a Seleção do jogador: ");
                        selecaoFigurinha = Console.ReadLine();
                        Console.WriteLine("Digite o jogador da figurinha: ");
                        jogadorFigurinha = Console.ReadLine();
                        cadastro.cadastraRepetida(codigoFigurinha, selecaoFigurinha, jogadorFigurinha);
                        cadastro.fechaArquivo();
                        break;
                    case 3:
                        cadastro.listarRepetida();
                        break;
                    case 4:
                        cadastro.listarFaltante();
                        break;
                    default:
                        laco = 1;
                        break;
                }        
            }
            Console.WriteLine("Fim da Operação!");
        }
    }
}
