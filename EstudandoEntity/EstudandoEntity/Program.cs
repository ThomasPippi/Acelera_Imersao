using EstudandoEntity.DataModels;
using Microsoft.EntityFrameworkCore;

namespace EstudandoEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite: \n" + "1 - Criar uma Pessoa\n" + "2 - Alterar o nome da Pessoa\n" + "3 - Inserir um Email\n" + "4 - Excluir uma Pessoa\n" + "5 - Consultar Tudo\n" + "6 - Consultar pelo ID");
            int op = int.Parse(Console.ReadLine());
            Contexto contexto = new Contexto();
            switch(op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Insira o nome da Pessoa: ");
                        Pessoa p = new Pessoa();
                        p.nome = Console.ReadLine();
                        Console.WriteLine("Informe um email:");
                        string emailTemp = Console.ReadLine();
                        p.Emails = new List<Email>() {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };
                        contexto.pessoas.Add(p);
                        contexto.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa pAlt = contexto.pessoas.Find(id);
                        Console.WriteLine("Informe o nome correto: ");
                        pAlt.nome = Console.ReadLine();
                        contexto.pessoas.Update(pAlt);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.pessoas.Find(id);
                        Console.WriteLine("Digite o novo email: ");
                        string emailTemp = Console.ReadLine();
                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };
                        contexto.pessoas.Update(p);
                        contexto.SaveChanges();
                        Console.WriteLine("Inserido com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa a ser excluida: ");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.pessoas.Find(id);
                        Console.WriteLine("Confirmar a exclusão de " + p.nome);
                        Console.WriteLine("E seus emails:");
                        foreach(Email item in p.Emails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }
                        Console.WriteLine("1 para SIM e qualquer outra tecla para NÂO");
                        if(int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine(p.nome + " excluída com sucesso!");
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        List<Pessoa> lista = (from Pessoa p in contexto.pessoas 
                                              select p).Include(pes => pes.Emails).ToList<Pessoa>();
                        foreach(Pessoa item in lista)
                        {
                            Console.WriteLine(item.id + " - " + item.nome);
                            foreach(Email itemE in item.Emails)
                            {
                                Console.WriteLine("\t" + itemE.email);
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        Console.WriteLine("Informe o ID da Pessoa: ");
                        int idPessoa = int.Parse(Console.ReadLine());
                        Pessoa pessoa = contexto.pessoas.Include(p => p.Emails).FirstOrDefault(x => x.id == idPessoa);
                        Console.WriteLine(pessoa.nome);
                        if(pessoa.Emails != null)
                        {
                            foreach(Email item in pessoa.Emails)
                            {
                                Console.WriteLine("   " + item.email);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.Write("Escolha uma opção válida!");
                    break;
            }
        }
    }
}