namespace Aplicacao_Bancaria.Exceptions;

public class LimiteInsuficienteException : Exception
{
    public LimiteInsuficienteException() 
        : base("Limite insuficiente!")
    {
    }
    
    public LimiteInsuficienteException(string message) 
        : base(message)
    {
    }
    
    public LimiteInsuficienteException(string message, Exception innerException) 
        : base(message, innerException)
    {
    }
}