using System;
using System.Collections.Generic;

namespace eita
{
    class Program
    {
        static List<string> Participantes = new List<string>();
        static void Main(string[] args)
        {
            int Digite;

            do
            {
                Console.WriteLine("Digite uma das opções");
                Console.WriteLine("Digite 1 - para cadastrar-se");
                Console.WriteLine("Digite 2 - para ver a lista de participantes");
                Console.WriteLine("Digite 0 - para sair");

                Digite = int.Parse(Console.ReadLine());


                switch (Digite)
                {
                    case 1:
                        Console.WriteLine("Qual seu nome?");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Qual sua idade?");
                        int idade = int.Parse(Console.ReadLine());

                        if (idade < 16)
                        {
                           
                                
                            Console.WriteLine("Constatamos que você tem " + idade + " anos,você estará acompanhado de um responsavel?");
                            string Responsavel = Console.ReadLine();
                         do
                         {
                             
                            switch (Responsavel)
                            {
                                case "sim":
                                    Console.WriteLine("Seu cadastro foi efetuado com sucesso!");
                                    Participantes.Add(nome);
                                    break;
                                case "não":
                                    Console.WriteLine("Você não podera participar do evento");
                                    break;

                                default:
                                    Console.WriteLine("Resposta invalida");
                                    break;
                            
                            }
                         } while (Responsavel==default);

                        }

                        else
                        {
                            Console.WriteLine("Seu cadastro foi efetuado com sucesso!");
                            Participantes.Add(nome);
                        }
                        Console.WriteLine("Deseja realizar outro cadastro? sim/não");
                        string resposta = Console.ReadLine().ToLower();



                        break;
                    case 2:
                        Console.WriteLine();
                        {
                            Console.WriteLine("Lista de participantes");
                            ListarParticipantes();
                        }
                        break;

                    case 0:
                        Console.WriteLine("Tchau");

                        break;
                    default:
                        Console.WriteLine("Opção invalida");

                        break;

                }
            } while (Digite != 0);



        }
        static void ListarParticipantes()
        {
            foreach (string cadanome in Participantes)
            {
                Console.WriteLine(cadanome);
            }

        }
    }

}
