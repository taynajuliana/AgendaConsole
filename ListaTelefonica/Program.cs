

using System;
using System.Collections.Generic;
using System.Linq;

namespace Testes1
{
    
    public class Contato
    {
        public string nome { get; set; }
        public string numero { get; set; }

        
    }


   public class Program
    {
        public static List<Contato> agenda = new List<Contato>();

        public static void Main(string[] args)
        {
            Iniciar();
            ExibirMenu();
        }
        static void AdicionarPessoa()
        {
            Contato pessoa = new Contato();
            Console.Write("Digite o nome a ser cadastrado:");
            Console.WriteLine("\n");
            pessoa.nome = Console.ReadLine();
            Console.Write("Digite o número a ser cadastrado:");
            Console.WriteLine("\n");
            pessoa.numero = Console.ReadLine();
            agenda.Add(pessoa);
        }
        static void Iniciar()
        {
            Console.WriteLine("AGENDA TELEFÔNICA NO CONSOLE");
            Console.WriteLine("Pressione Enter para ver as opções ...");
            Console.WriteLine("------------------------");
            Console.ReadLine();
        }
        static void ListarContatos()
        {
            agenda = agenda.OrderBy(x => x.nome).ToList();
            Console.WriteLine("A lista tem " + agenda.Count + " itens:");
            foreach (Contato v in agenda)
            {
                Console.WriteLine(v.nome + " " + v.numero);
            }
        }
        static void ExibirMenu()
        {
            Console.WriteLine("1 - CADASTRAR NÚMERO");
            Console.WriteLine("2 - LISTA TELEFÔNICA");
            Console.WriteLine("3 - SAIR");
            Console.WriteLine("\n");
            ExecutaOpcoes();
        }
        static void ExecutaOpcoes()
        {
            int opcao = 0;
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    AdicionarPessoa();
                    ExibirMenu();
                    break;
                case 2:
                    ListarContatos();
                    ExibirMenu();
                    break;
                case 3:
                    break;
            }
        }
    }
}





