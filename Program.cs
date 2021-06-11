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
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
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
        private static void Depositar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser depositado: ");
			double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
		}

		private static void Sacar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser sacado: ");
			double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
		}

		private static void Transferir()
		{
			Console.Write("Digite o número da conta de origem: ");
			int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
			int indiceContaDestino = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser transferido: ");
			double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
		}

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if(listContas.Count == 0)
            {
                Console.WriteLine("NENHUMA CONTA REGISTRADA NO XERETABANK, POR FAVOR REGISTRE-SE!");
                return;
            }
            for(int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.WriteLine("#{0} - ", i);
                Console.WriteLine(conta);

            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite 1 para CF, ou 2 para CJ: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite seu nome: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite seu saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: 
                                            (TipoConta)entradaTipoConta,
                                            saldo: entradaSaldo,
                                            credito: entradaCredito,
                                            nome: entradaNome);
            listContas.Add(novaConta);
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
