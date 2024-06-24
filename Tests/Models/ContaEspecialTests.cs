using Aplicacao_Bancaria.Exceptions;
using Aplicacao_Bancaria.Models;
using Xunit;

namespace Aplicacao_Bancaria.Tests.Models;

public class ContaEspecialTests
{
    [Fact]
    public void Sacar_QuandoLimiteCobreValorDeSaque_DeveAtualizarSaldo()
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

    [Fact]
    public void Depositar_QuandoValorDeDepositoInvalido_DeveLancarExcecao()
    {
        // Arrange
        var contaEspecial = new ContaEspecial(1, 1000);

        // Act & Assert
        Assert.Throws<DepositoNegativoException>(() => contaEspecial.Depositar(-500));
    }

    [Fact]
    public void Sacar_QuandoSaldoMenorQueValorDeSaque_DeveLancarExcecao()
    {
        // Arrange
        var contaEspecial = new ContaEspecial(1, 1000);

        // Act & Assert
        Assert.Throws<LimiteInsuficienteException>(() => contaEspecial.Sacar(1500));
    }

    [Fact]
    public void MostrarDados_QuandoChamado_DeveRetornarDadosDaContaEspecial()
    {
        // Arrange
        var contaEspecial = new ContaEspecial(1, 1000);

        // Act
        var resultado = contaEspecial.MostrarDados();
        const string resultadoEsperado = "Conta Especial\nNúmero da Conta: 1\nSaldo: R$ 0\nLimite: R$ 1000";

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}