// See https://aka.ms/new-console-template for more information
using Projeto.DataModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

var dados = Assembly.GetExecutingAssembly();

Console.WriteLine(dados.GetName());

var pessoaNova = new Pessoa
{
    Nome = "Joao",
    Sexo = Sexo.Masculino,
};








var tipoDeDados = pessoaNova.GetType();
Console.WriteLine(tipoDeDados.FullName);
Console.WriteLine(pessoaNova.Nome.GetType());


var path = @"E:\Formacoes\Moongy\DOTNETCORE2022\Aula06\ExemploHeranca\bin\Debug\net6.0\ComponentesComuns.dll";
var infoSobre = Assembly.LoadFrom(path);
var tipo = infoSobre.GetType();
var propriedades = tipo.GetProperties();
var metodos = tipo.GetMethods();









Console.ReadLine();


