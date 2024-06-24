using Aplicacao_Bancaria.Models;
using Xunit;

namespace Aplicacao_Bancaria.Tests.Models;

public class ContaCorrenteTests
{
    [Fact]
    public void Sacar_QuandoSaldoMaiorQueValorDeSaque_DeveAtualizarSaldo()
    {
        // Arrange
        var contaCorrente = new ContaCorrente(1, 5);
        
        // Act
        contaCorrente.Depositar(1000);
        contaCorrente.Sacar(500);
        const int resultadoEsperado = 490;
        
        // Assert
        Assert.Equal(resultadoEsperado, contaCorrente.Saldo);
    }
    
    [Fact]
    public void Depositar_QuandoValorDeDepositoValido_DeveAtualizarSaldo()
    {
        // Arrange
        var contaCorrente = new ContaCorrente(1, 5);
        
        // Act
        contaCorrente.Depositar(500);
        const int resultadoEsperado = 495;
        
        // Assert
        Assert.Equal(resultadoEsperado, contaCorrente.Saldo);
    }
}