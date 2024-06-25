namespace Aplicacao_Bancaria.Exceptions;

public class DepositoNegativoException : Exception
{
    public DepositoNegativoException() 
        : base("Não é possível depositar um valor negativo!")
    {
    }
    
    public DepositoNegativoException(string message) 
        : base(message)
    {
    }
    
    public DepositoNegativoException(string message, Exception innerException) 
        : base(message, innerException)
    {
    }
}