// See https://aka.ms/new-console-template for more information
using ExemploHeranca.Modelo.Banco;
using ExemploHeranca.Modelo.Loja;
using ExemploHeranca.Modelo.Operacoes;

Console.WriteLine("Hello, World!");


var contaDaLais = new ContaCarro();
var saldoLais = contaDaLais.CalcularSaldo();
Console.WriteLine(saldoLais); 



var contaDoLeonardo = new ContaCorrente();
contaDoLeonardo.IBAN = "1222";
var saldoLeonardo = contaDoLeonardo.CalcularSaldoComumParaTodos();
Console.WriteLine(saldoLeonardo);


var contaVictor = new ContaPoupanca();
contaVictor.CalcularSaldoComumParaTodos();
contaVictor.TaxaJuros = 90;


var minhaListaContas = new List<Conta>();
minhaListaContas.Add(contaDaLais);
minhaListaContas.Add(contaDoLeonardo);
minhaListaContas.Add(contaVictor);


foreach (var item in minhaListaContas)
{
    item.CalcularSaldoAbstrato();
    item.Gravar(item);
    item.Exibir();
}

var cliente = new Cliente("maria","minhaPropr");
cliente.Exibir();

var minhaListaExibicoes = new List<IExibicao>();
minhaListaExibicoes.Add(contaDaLais);
minhaListaExibicoes.Add(cliente);


foreach (var item in minhaListaExibicoes)
{
    item.Exibir();
}


Console.ReadLine();

