using Aplicacao_Bancaria.Exceptions;

namespace Aplicacao_Bancaria.Models;

public class ContaEspecial : ContaBancaria
{
    private double Limite { get; set; }

    public ContaEspecial(int numeroConta, double limite)
    {
        NumeroConta = numeroConta;
        Limite = limite;
    }

    public override void Sacar(double valor)
    {
        if (Saldo + Limite < valor)
        {
            throw new LimiteInsuficienteException();
        }

        Saldo -= valor;
        Console.WriteLine($"Saque de R$ {valor} realizado com sucesso!");
    }

    public override void Depositar(double valor)
    {
        if (valor < 0)
        {
            throw new DepositoNegativoException();
        }

        Saldo += valor;
        Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso!");
    }

    public string MostrarDados()
    {
        return $"Conta Especial\nNúmero da Conta: {NumeroConta}\nSaldo: R$ {Saldo}\nLimite: R$ {Limite}";
    }
}