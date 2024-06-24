using Aplicacao_Bancaria.Exceptions;
using Xunit;

namespace Aplicacao_Bancaria.Tests.Exceptions;

public class SaldoInsuficienteExceptionTests
{
    [Fact]
    public void DadoSaldo_QuandoSaldoMenorQueValorDeSaque_DeveLancarExcecao()
    {
        // Arrange & Act
        var exception = new SaldoInsuficienteException();
        const string resultadoEsperado = "Saldo insuficiente!";

        // Assert
        Assert.Equal(resultadoEsperado, exception.Message);
    }
}