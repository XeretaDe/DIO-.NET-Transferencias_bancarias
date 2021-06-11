using System;
using System.Collections.Generic;
using DIO_.NET_Transferencias_bancarias.Classes;

namespace DIO_.NET_Transferencias_bancarias
{
    class Program
    {

        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObtainUser();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        //ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        //Transferir();
                        break;
                    case "4":
                        //Sacar();
                        break;
                    case "5":
                        //Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                    throw new ArgumentOutOfRangeException();

                }
            opcaoUsuario = ObtainUser();
            }

            Console.WriteLine("Obrigado por fazer parte do XeretaBank! Use seu XereCard com sabedoria.");
            Console.ReadLine();

        }

        private static void InserirConta()
        {
            throw new NotImplementedException();
        }

        private static string ObtainUser()
    {
        Console.WriteLine();
        Console.WriteLine("Bem vindo ao XeretaBank, o único banco com o Xerecard!");
        Console.WriteLine("Informe-nos o seu desejo:");

        Console.WriteLine();
        Console.WriteLine("1- Listar contas");
        Console.WriteLine("2- Inserir uma nova conta");
        Console.WriteLine("3- Fazer um TED");
        Console.WriteLine("4- Realizar um saque.");
        Console.WriteLine("5- Realizar um depósito");
        Console.WriteLine("C- Limpar a tela");
        Console.WriteLine("X- Sair");
        Console.WriteLine();

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;   
    }



    }
}
