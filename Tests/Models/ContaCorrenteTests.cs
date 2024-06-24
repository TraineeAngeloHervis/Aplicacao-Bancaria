using Aplicacao_Bancaria.Exceptions;
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

    [Fact]
    public void Depositar_QuandoValorDeDepositoInvalido_DeveLancarExcecao()
    {
        // Arrange
        var contaCorrente = new ContaCorrente(1, 5);

        // Act & Assert
        Assert.Throws<DepositoNegativoException>(() => contaCorrente.Depositar(-500));
    }

    [Fact]
    public void Sacar_QuandoSaldoMenorQueValorDeSaque_DeveLancarExcecao()
    {
        // Arrange
        var contaCorrente = new ContaCorrente(1, 5);

        // Act & Assert
        Assert.Throws<SaldoInsuficienteException>(() => contaCorrente.Sacar(500));
    }

    [Fact]
    public void MostrarDados_QuandoChamado_DeveRetornarDadosDaContaCorrente()
    {
        // Arrange
        var contaCorrente = new ContaCorrente(1, 5);

        // Act
        contaCorrente.Depositar(1000);
        contaCorrente.Sacar(500);
        const string resultadoEsperado = "Conta Corrente\nNúmero da Conta: 1\nSaldo: R$ 490\nTaxa de Operação: R$ 5";

        // Assert
        Assert.Equal(resultadoEsperado, contaCorrente.MostrarDados());
    }
}