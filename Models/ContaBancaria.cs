namespace Aplicacao_Bancaria.Models;

public abstract class ContaBancaria
{
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }

    public abstract void Sacar(double valor);
    public abstract void Depositar(double valor);
    }