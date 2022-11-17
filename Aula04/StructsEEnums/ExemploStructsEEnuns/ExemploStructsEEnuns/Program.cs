// See https://aka.ms/new-console-template for more information
using ExemploStructsEEnums.Model.Classes;
using ExemploStructsEEnums.Model.Enumeradores;
using ExemploStructsEEnums.Model.Estruturas;
using ExemploStructsEEnums.Model.Record;
using System.Drawing;

Console.WriteLine("Hello, World!");



var dia = new DiaDeTrabalho();
dia.Ano = 2022;
dia.Dia = 01;
dia.Mes = 01;

dia.diaDaSemana = DiasDaSemana.Sabado;


var minhaCorFavoritaEh = Color.Green;


var fulano = Sexo.Masculino;


var fulana = (Sexo)2002;

if((int)Sexo.Feminino ==  2002)
{
    Console.WriteLine("Bem vinda");
}
else
{
    Console.WriteLine("Bem vindo");
}


var maria = new Pessoa( 1, "maria");
var ende = new Endereco();


var pedro = new PessoaSingular();
pedro.NumeroDoContribuinte = "123.456.789";
pedro.NIF = "123.456.789";
pedro.Validar();


Console.WriteLine(pedro.NumeroDoContribuinte);
Console.WriteLine(pedro.NIF);



"lais".ConverterPrimeiraLetraParaMaiusculas();



Console.ReadLine();