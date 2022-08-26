using System;
using System.IO;

namespace aula4
{

    class Program
    {
        static bool cadastrar(string username, string password);
        {
            string linha = username + "e" + password;

            File.AppendAllText("users.txt", linha);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("Digite 1 para logar.");
            Console.WriteLine("Digite 2 para cadastrar.");
            Console.WriteLine("Digite 3 para sair.");

            bool sair = false;
            while(!sair)
            {
                int opcao = 0;

                try
                {
                opcao = int.Parse(Console.ReadLine());
                }
                catch(Exception erro)
                {
                    // nada
                }
                switch(opcao)
                {
                    case 1:
                        // logar
                        break;
                    case 2:
                        Console.WriteLine("Digite um nome de usuario")
                        string username = Console.ReadLine();
                        Console.WriteLine("Digite uma senha")
                        string password = Console.ReadLine();
                        Console.WriteLine("Confirme sua senha")
                        string confirm = Console.ReadLine();
                        if(password != confirm)
                        {
                            Console.WriteLine("As senhas nao coincidem, tente novamente")
                        }
                        else
                        {
                            if(cadastrar(username, password))
                            {
                                Console.WriteLine("Cadastro efetuado")
                            }
                            else
                            {
                                Console.WriteLine("Nao foi possivel cadastrar, tente novamente")
                            }
                        }
                        break;
                    case 3:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opcao invalida, tente novamente");
                        break;        
                }
            }

        }
    }
}
