using Aplicacao_Bancaria.Exceptions;

namespace Aplicacao_Bancaria.Models;

public class ContaCorrente : ContaBancaria
{
    private double TaxaDeOperacao { get; set; }

    public ContaCorrente(int numeroConta, double taxaDeOperacao)
    {
        NumeroConta = numeroConta;
        TaxaDeOperacao = taxaDeOperacao;
    }

    public override void Sacar(double valor)
    {
        if (Saldo < valor + TaxaDeOperacao)
        {
            throw new SaldoInsuficienteException();
        }

        Saldo -= valor + TaxaDeOperacao;
        Console.WriteLine($"Saque de R$ {valor} realizado com sucesso!");
    }

    public override void Depositar(double valor)
    {
        if (valor < 0)
        {
            throw new DepositoNegativoException();
        }

        Saldo += valor - TaxaDeOperacao;
        Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso!");
    }

    public string MostrarDados()
    {
        return
            $"Conta Corrente\nNúmero da Conta: {NumeroConta}\nSaldo: R$ {Saldo}\nTaxa de Operação: R$ {TaxaDeOperacao}";
    }
}