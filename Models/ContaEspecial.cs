namespace Aplicacao_Bancaria.Models;

public class ContaEspecial : ContaBancaria
{
    private double Limite { get; set; }
    
    public ContaEspecial (int numeroConta, double limite)
    {
        NumeroConta = numeroConta;
        Limite = limite;
    }
    
    public override void Sacar(double valor)
    {
        if (Saldo + Limite >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor} realizado com sucesso!");
        }
        if (Saldo + Limite < valor)
        {
            Console.WriteLine("Saque não realizado! Saldo insuficiente!");
        }
    }
    
    public override void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso!");
    }
    
    public void MostrarDados()
    {
        Console.WriteLine($"Conta Especial\nNúmero da Conta: {NumeroConta}\nSaldo: R$ {Saldo}\nLimite: R$ {Limite}");
    }
}