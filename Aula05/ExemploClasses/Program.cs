// See https://aka.ms/new-console-template for more information
using ExemploClasses;
using ExemploClasses.ClassesEstaticas;
using ExemploClasses.Pessoas;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");



        var lais = new Pessoa();
        lais.Id = 1;
        lais.Nome = "Laís";
        //lais.Idade = 15;
        lais.InformarIdade(new DateTime(2007, 01, 01));
        //lais.MinhaPropriedadeProtegida = 10;



        var irmaDaLais = lais;

        Console.WriteLine(irmaDaLais.Nome);




        Impressora.Imprimir(irmaDaLais);


        Pessoa.ExemploMetodoEstatico();

        var calc = new Calculadora.Calculadora();
        Console.WriteLine(calc.Somar(1, 2));

    }
}