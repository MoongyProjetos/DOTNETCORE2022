// See https://aka.ms/new-console-template for more information
using ExemploHerancaFramework.Model;
using ExemploHerancaFramework.MyFramework;

Console.WriteLine("Hello, World!");


//throw new MinhaExceptionCustomizada("Erro na rebimboca da parafuseta");

try
{
    var valor = 0;
    var divisor = 0;
    var operacao = valor / divisor;
}
catch (Exception)
{
   // throw new MinhaExceptionCustomizada("Erro na rebimboca da parafuseta", new DivideByZeroException("Divisao por zero de exemplo"));
}



var diego = new Pessoa();
var jonatas = new Pessoa();

var list = new MinhaListaCustomizada();
list.Add(diego);
list.Add(jonatas);


list.SortByName();
list.SortById();



var nif = "123456789";
nif.ToNumeroContribuinte();
nif.ValidarNif();


"987654321".ToNumeroContribuinte();
"987654321".ValidarNif();


"987654".ValidarNif();



Console.ReadLine();