using Aplicacao_Bancaria.Exceptions;
using Xunit;

namespace Aplicacao_Bancaria.Tests.Exceptions;

public class LimiteInsuficienteExceptionTests
{
    [Fact]
    public void DadoLimite_QuandoSaldoMenorQueValorDeSaque_DeveLancarExcecao()
    {
        // Arrange & Act
        var exception = new LimiteInsuficienteException();
        const string resultadoEsperado = "Limite insuficiente!";

        // Assert
        Assert.Equal(resultadoEsperado, exception.Message);
    }
}