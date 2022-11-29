// See https://aka.ms/new-console-template for more information
using ExemploFileIO;

Console.WriteLine("Hello, World!");


//Verificar se o diretorio existe
//Cria o diretorio

var path = @"e:\temp\exemplo.txt";
var conteudo = System.IO.File.ReadAllText(path);

Console.WriteLine(conteudo);

var pathCsv = @"e:\temp\ExemploFinancas.csv";
var conteudoCsv = System.IO.File.ReadAllLines(pathCsv);


//
//ID;NOMECONTRIBUINTE;NIF;DADOSBANCARIOS
var minhaLista = new List<DadosFinancas>();
var pathTAB = @"e:\temp\ExemploFinancasTab.csv";

if (File.Exists(pathTAB))
{
    File.Delete(pathTAB);
}



for (int i = 1; i <= conteudoCsv.Length - 1; i++)
{
    var dadosSeparados = conteudoCsv[i].Split(';');

    var dados = new DadosFinancas();
    dados.Id = Convert.ToInt32(dadosSeparados[0]);
    dados.NomeContribuinte= dadosSeparados[1];
    dados.Nif = dadosSeparados[2];
    dados.DadosBancarios = dadosSeparados[3].Substring(0,4);


    File.AppendAllText(pathTAB, $"{dados.NomeContribuinte}\t{dados.Nif}\n");
    minhaLista.Add(dados); 
}




var dadosArquivo = File.GetCreationTime(pathTAB);

var dadosAvancadosArquivo = new FileInfo(pathTAB);



var relatorioDiario = @"e:\temp\Relatorios\20221124";
if (!Directory.Exists(relatorioDiario))
{
    Directory.CreateDirectory(relatorioDiario);
}

if (Directory.Exists(relatorioDiario))
{
    File.AppendAllText(relatorioDiario + @"\dia.txt", "Dados xpto");
}



var conteudoDaTemp = Directory.GetFiles(@"e:\temp\");


//var conteudoDirDaTemp = Directory.GetDirectories(@"e:\temp\");
//foreach (var item in conteudoDirDaTemp)
//{
//    Directory.GetDirectories(item);
//}



var dadosDiretorio = new DirectoryInfo(@"e:\temp\");
var sub = dadosDiretorio.GetDirectories();


var possuiExtensao = Path.GetExtension(pathTAB);


Console.ReadLine();
