// See https://aka.ms/new-console-template for more information
using ExemploInterfaces.Classes;
using ExemploInterfaces.Contratos;

Console.WriteLine("Hello, World!");


var aluno = new Alunos();
aluno.NumeroAluno = 1;
aluno.NomeDoAluno = "José";
aluno.Salvar();


IDesconto meuObjetoComDesconto = new Materias(); //DIP - Principio da Inversão de Dependencia

meuObjetoComDesconto.AplicarDesconto(10M);


