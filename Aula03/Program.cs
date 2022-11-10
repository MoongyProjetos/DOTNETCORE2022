// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine($"Linha {i}");
}


var contador = 10;
while (contador > 0)
{
    System.Console.WriteLine($"Contador {contador}");
    contador--;
    //contador =- 1;
    //contador = contador - 1;
}



//[0 .. N-1]
var listaCompras = new String[5];
listaCompras[0] = "Banana";
listaCompras[1] = "Laranja";
listaCompras[4] = "Abacaxi";
listaCompras[0] = "Banana da Madeira";
listaCompras[3] = "Pêssego";
listaCompras[2] = "Jaca";

foreach (var item in listaCompras)
{
    System.Console.WriteLine(item);
}

for (int i = 0; i <= listaCompras.Length - 1; i++)
{
    System.Console.WriteLine(listaCompras[i]);
}

var exemploDeCriatividade = 0;
for (int j = 0; exemploDeCriatividade < 5; System.Console.WriteLine("Hagada à vista"))
{
    System.Console.WriteLine($"Hagada Continua j: {j} ExemploCriatividade: {exemploDeCriatividade}");
    exemploDeCriatividade++;
}


do
{
    System.Console.WriteLine($"ExemploCriatividade: {exemploDeCriatividade}");
    exemploDeCriatividade++;
} while (exemploDeCriatividade <= 10);


//A,B
//C, D

var multidimensao = new int[2, 2];
multidimensao[0, 0] = 'A';
multidimensao[0, 1] = 'B';
multidimensao[1, 0] = 'C';
multidimensao[1, 1] = 'D';

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        System.Console.WriteLine($"O valor da variável {i},{j} {(char)multidimensao[i, j]}");
    }
}



Console.WriteLine(Calculadora.Somar(1, 2));
Console.WriteLine(Calculadora.Somar(false, false));
Console.WriteLine(Calculadora.Somar("true", "true"));

var minhaVariavel = "Teste";
System.Console.WriteLine(minhaVariavel);

CalculadoraDeApolice.ExemploPorReferencia(ref minhaVariavel);
System.Console.WriteLine(minhaVariavel);


CalculadoraDeApolice.Vai("A", "B");
CalculadoraDeApolice.Vai(a: "A", b: "B");

var pesso = new PessoaDto();
CalculadoraDeApolice.Vai(a: "A", b: "B", out minhaVariavel, out pesso);


System.Console.WriteLine(minhaVariavel);


var divisor = 0;
if (divisor != 0)
{
    try
    {
        var meuValor = 10 / divisor;
    }
    catch (System.DivideByZeroException ex)
    {
        System.Console.WriteLine("Divisao por zero");
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
}


throw new MinhaException();




///TblOperacoes 
//NomeOperacao : CadCliente
//Valor varchar(max):  "Insert into cliente (nome, ...) values ( '", ...))


//abcd,1234
//abcd1234
//maria;'Delete from cliente'

