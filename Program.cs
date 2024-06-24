using Aplicacao_Bancaria.Models;

var contaCorrente1 = new ContaCorrente(1, 5);
var contaCorrente2 = new ContaCorrente(2, 5);
var contaEspecial1 = new ContaEspecial(2, 1000);
var contaEspecial2 = new ContaEspecial(2, 2000);

contaCorrente1.Depositar(100);
contaCorrente1.Sacar(50);
contaCorrente1.MostrarDados();

contaCorrente2.Depositar(200);
contaCorrente2.Sacar(100);
contaCorrente2.MostrarDados();

contaEspecial1.Depositar(300);
contaEspecial1.Sacar(200);
contaEspecial1.MostrarDados();

contaEspecial2.Depositar(400);
contaEspecial2.Sacar(300);
contaEspecial2.MostrarDados();

contaEspecial1.Sacar(2000);
contaEspecial1.MostrarDados();
