using Aplicacao_Bancaria.Models;
using Xunit;

namespace Aplicacao_Bancaria.Tests.Models;

public class ContaEspecialTests
{
    [Fact]
    public void Sacar_QuandoSaldoMaiorQueValorDeSaque_DeveAtualizarSaldo()
    {
        // Arrange
        var contaEspecial = new ContaEspecial(1, 1000);
        
        // Act
        contaEspecial.Sacar(500);
        const int resultadoEsperado = -500;
        
        // Assert
        Assert.Equal(resultadoEsperado, contaEspecial.Saldo);
    }
    
    [Fact]
    public void Depositar_QuandoValorDeDepositoValido_DeveAtualizarSaldo()
    {
        // Arrange
        var contaEspecial = new ContaEspecial(1, 1000);
        
        // Act
        contaEspecial.Depositar(500);
        const int resultadoEsperado = 500;
        
        // Assert
        Assert.Equal(resultadoEsperado, contaEspecial.Saldo);
    }
}