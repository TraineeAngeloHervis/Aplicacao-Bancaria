namespace Aplicacao_Bancaria.Exceptions;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException()
        : base("Saldo insuficiente!")
    {
    }

    public SaldoInsuficienteException(string message)
        : base(message)
    {
    }

    public SaldoInsuficienteException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}