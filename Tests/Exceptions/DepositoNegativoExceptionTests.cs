using Aplicacao_Bancaria.Exceptions;
using Xunit;

namespace Aplicacao_Bancaria.Tests.Exceptions;

public class DepositoNegativoExceptionTests
{
    [Fact]
    public void DepositoNegativoException_QuandoValorDepositoNegativo_DeveLancarExcecao()
    {
        // Arrange & Act
        var exception = new DepositoNegativoException();
        const string resultadoEsperado = "Não é possível depositar um valor negativo!";
        
        // Assert
        Assert.Equal(resultadoEsperado, exception.Message);
    }
}