using System;
namespace DIO_.NET_Transferencias_bancarias.Classes
{
    public class Conta
    {

        private TipoConta TipoConta {get;set;}

        private double Saldo {get;set;}

        private double Credito{get;set;}
        private string Nome{get;set;}
        
    public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
    {

        this.TipoConta = tipoConta;
        this.Saldo = saldo;
        this.Credito = credito;
        this.Nome = nome;

    }

    public bool Sacar(double valorSaque)
    {
        if(this.Saldo - valorSaque < (this.Credito *-1))
        {
            Console.WriteLine("Seu saldo não é suficiente!");
            return false;

        }
        this.Saldo -= valorSaque;

        Console.WriteLine("Bom dia, {0}, seu novo saldo é de {1} R$", this.Nome, this.Saldo);

        return true;
    }

    public void Depositar(double valorDeposito)
    {
        this.Saldo += valorDeposito;
        Console.WriteLine("Bom dia, {0}, seu novo saldo é de {1} R$", this.Nome, this.Saldo);

    }

    public void Transferir(double valorTransferencia, Conta contaDestino)
    {
        if(this.Sacar(valorTransferencia))
        {
        contaDestino.Depositar(valorTransferencia);
        }

    }

        public override string ToString()
        {
            string returning = "";
            returning += "Tipo da conta " + this.TipoConta + " | ";
            returning += "Nome " + this.Nome + " | ";
            returning += "Saldo " + this.Saldo + " | ";
            returning += "Crédito " + this.Credito + " | ";

            return returning;
        }


    }




}