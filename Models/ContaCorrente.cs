namespace Aplicacao_Bancaria.Models;

public class ContaCorrente : ContaBancaria, Imprimivel
{
    private double TaxaDeOperacao { get; set; }
    
    public ContaCorrente (int numeroConta, double taxaDeOperacao)
    {
        NumeroConta = numeroConta;
        TaxaDeOperacao = taxaDeOperacao;
    }

    public override void Sacar(double valor)
    {
        if (Saldo >= valor + TaxaDeOperacao)
        {
            Saldo -= valor + TaxaDeOperacao;
            Console.WriteLine("Saque de R$ {valor} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }
    
    public override void Depositar(double valor)
    {
        Saldo += valor - TaxaDeOperacao;
        Console.WriteLine("Depósito de R$ {valor} realizado com sucesso!");
    }
    
    public void MostrarDados()
    {
        Console.WriteLine($"Conta Corrente\nNúmero da Conta: {NumeroConta}\nSaldo: R$ {Saldo}\nTaxa de Operação: R$ {TaxaDeOperacao}");
    }
}