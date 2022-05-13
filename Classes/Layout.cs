using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMartins.Classes
{
    public class Layout
    {


        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("Digite a Opção desejada:");
            Console.WriteLine("=========================");
            Console.WriteLine("1: Criar conta");
            Console.WriteLine("=========================");
            Console.WriteLine("2: Entrar com CPF e Senha");
            Console.WriteLine("=========================");

            int escolha = int.Parse(Console.ReadLine());


            switch(escolha)
            {
                case 1: TelaCriarConta(); break;
                case 2: TelaLogin(); break;
                default: Console.WriteLine("Opção invalida"); break;
            }


            Console.ReadKey();

        }

        public static void TelaCriarConta()
        {
            Console.Clear();
            Console.WriteLine("Digite Seu nome:");
            Console.WriteLine("=========================");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite Seu CPF:");
            Console.WriteLine("=========================");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite Sua Senha(6 numeros):");
            Console.WriteLine("=========================");
            string senha = Console.ReadLine();

            {
                Console.WriteLine("Conta Criada com Sucesso");

            }

            Console.ReadKey();

        }

        public static void TelaLogin()
        {
            Console.Clear();

            Console.WriteLine("Digite Seu CPF:");
            string cpf = Console.ReadLine();
            Console.WriteLine("=========================");
            Console.WriteLine("Digite Sua Senha(6 numeros):");
            string senha = Console.ReadLine();
            Console.WriteLine("=========================");

            Console.ReadKey();

        }


    }

}
