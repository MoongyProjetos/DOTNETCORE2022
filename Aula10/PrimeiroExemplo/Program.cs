// See https://aka.ms/new-console-template for more information
Console.WriteLine("Inicio da Aplicacao");


var minhatask = new Task(() =>
{
    System.Console.WriteLine("Processo Rápido");
});
minhatask.Start();
minhatask.Wait();


var segundatask = new Task(() =>
{
    System.Console.WriteLine("Inicio Processo Lento");
    File.AppendAllText(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\PrimeiroExemplo\exemplo.txt", $"\nOi hoje é dia {DateTime.Now}");
    Thread.Sleep(10);
    System.Console.WriteLine("Final Processo Lento");
});
segundatask.Start();
segundatask.Wait();


//Thread.Sleep(10000);

Console.WriteLine("Final da Aplicacao");
