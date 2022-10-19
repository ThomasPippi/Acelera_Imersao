using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JOGO_DA_VELHA
{
    internal class jogodavelha
    {
        static char[] jogadas = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int jogador = 1;
        static int ganha = 0;
        static void Main(string[] args)
        {
            int escolha;
            string simboloJogador1 = "z", simboloJogador2 = "y";
            string jogador1, jogador2;        
            Console.WriteLine("BEM VINDO AO JOGO DA VELHA DO FROMBETAS! \n");
            Console.WriteLine("Insira o nome do Jogador 1: ");
            jogador1 = Console.ReadLine();
            Console.WriteLine("Bem vindo ao jogo, " + jogador1 + "!\n");
            Console.WriteLine("Insira o nome do Jogador 2: ");
            jogador2 = Console.ReadLine();
            Console.WriteLine("Bem vindo ao jogo, " + jogador2 + "!\n");
            // laço de repetição para forçar o jogador a escolher um símbolo válido.
            Console.WriteLine(jogador1 + ", escolha se quer usar X ou O em suas jogadas.");
            string verificaSimbolo = Console.ReadLine().ToUpper();
            simboloJogador1 = verificaSimbolo;
            while ((simboloJogador1 != "X" && simboloJogador1 != "O"))
            {
                Console.WriteLine(jogador1 + ", escolha se quer usar X ou O em suas jogadas.");
                simboloJogador1 = (Console.ReadLine()).ToUpper();
            }
                if (simboloJogador1 == "X")
                { // Convertendo escolha para UPPERCASE
                    simboloJogador1 = "X";
                    simboloJogador2 = "O";
                }
                else if (simboloJogador1 == "O")
                {
                    simboloJogador1 = "O";
                    simboloJogador2 = "X";
                }
                //Mostrando os simbolos escolhidos
                Console.WriteLine("\n" + jogador1 + " ficou com " + simboloJogador1);
                Console.WriteLine(jogador2 + " ficou com " + simboloJogador2);
                Console.WriteLine("\nVamos começar!");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine(jogador1 + " = " + simboloJogador1 + " | " + jogador2 + " = " + simboloJogador2);
                Console.WriteLine("Thomas começa escolhendo. \n");
            do
            {
                Console.Clear();
                Console.WriteLine(jogador1 + " = " + simboloJogador1 + " | " + jogador2 + " = " + simboloJogador2);
                Console.WriteLine("\n");
                if (jogador % 2 == 0)
                {
                    Console.WriteLine("Vez de " + jogador2 + " jogar. ");
                }
                else
                {
                    Console.WriteLine("Vez de " + jogador1 + " jogar. ");
                }
                Console.WriteLine("\n");
                Tabuleiro();
                escolha = int.Parse(Console.ReadLine());
                if (jogadas[escolha] != 'X' && jogadas[escolha] != 'O')
                {
                    if (jogador % 2 == 0)
                    {
                        jogadas[escolha] = simboloJogador2[0];
                        jogador++;
                    }
                    else
                    {
                        jogadas[escolha] = simboloJogador1[0];
                        jogador++;
                    }
                }
                else
                {
                    Console.WriteLine("A posição {0} já está marcada com {1}", escolha, jogadas[escolha]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Aguarde.");
                    Thread.Sleep(2000);
                }
                ganha = VerificaVitoria();                
            }
            while(ganha != 1 && ganha != 2);
            Console.Clear();
            Tabuleiro();
            if(ganha == 1)
            {
                int i = (jogador % 2) + 1;
                if (i == 1)
                {
                    Console.WriteLine("\n" + jogador1 + " venceu a partida!");
                }
                else
                {
                    Console.WriteLine("\n" + jogador2 + " vendeu a partida!");
                }
            }
            else
            {
                Console.WriteLine("\n Empate!");
            }
            Console.ReadLine();
        }
        private static void Tabuleiro()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", jogadas[1], jogadas[2], jogadas[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", jogadas[4], jogadas[5], jogadas[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", jogadas[7], jogadas[8], jogadas[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int VerificaVitoria()
        {
            #region Horizontal
            //Primeira linha
            if (jogadas[1] == jogadas[2] && jogadas[2] == jogadas[3])
            {
                return 1;
            }
            //Segunda linha
            else if (jogadas[4] == jogadas[5] && jogadas[5] == jogadas[6])
            {
                return 1;
            }
            //Terceira Linha
            else if (jogadas[6] == jogadas[7] && jogadas[7] == jogadas[8])
            {
                return 1;
            }
            #endregion
            #region Vertical
            //Primeira Coluna
            else if (jogadas[1] == jogadas[4] && jogadas[4] == jogadas[7])
            {
                return 1;
            }
            //Segunda Coluna
            else if (jogadas[2] == jogadas[5] && jogadas[5] == jogadas[8])
            {
                return 1;
            }
            //Terceira Coluna
            else if (jogadas[3] == jogadas[6] && jogadas[6] == jogadas[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal
            else if (jogadas[1] == jogadas[5] && jogadas[5] == jogadas[9])
            {
                return 1;
            }
            else if (jogadas[3] == jogadas[5] && jogadas[5] == jogadas[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // Se todos campos estiverem preenchidos e não houver combinações = Empate
            else if (jogadas[1] != '1' && jogadas[2] != '2' && jogadas[3] != '3' && jogadas[4] != '4' && jogadas[5] != '5' && jogadas[6] != '6' && jogadas[7] != '7' && jogadas[8] != '8' && jogadas[9] != '9')
            {
                return 2;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}

