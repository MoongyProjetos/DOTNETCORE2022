// See https://aka.ms/new-console-template for more information
Console.WriteLine("Inicio");

var primeiraTask = new Task(
    () => {
            File.AppendAllText(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\QuartoExemplo\1.txt", $"\n{DateTime.Now}");
            Thread.Sleep(10000);    
        });
var segundaTask = new Task(() => File.AppendAllText(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\QuartoExemplo\2.txt", $"\n{DateTime.Now}") );
primeiraTask.ContinueWith(a => segundaTask);


Console.WriteLine("Final");
Console.ReadLine();

