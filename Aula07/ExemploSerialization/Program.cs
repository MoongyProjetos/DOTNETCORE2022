// See https://aka.ms/new-console-template for more information
using ExemploSerialization.Model;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");


var listaPessoas = new List<Pessoa>();

for (int i = 0; i < 1000; i++)
{
    var id = Guid.NewGuid();
    var ano = new Random().Next(20);
    var p = new Pessoa
    {
        Id = id,
        Nome = "Pessoa " + i,
        DataNascimento = new DateTime(ano + 2000, 1, 1),
        Historico = ""
    };

    listaPessoas.Add(p);
}



//Serializar com .NET CORE
var conteudoCore = System.Text.Json.JsonSerializer.Serialize(listaPessoas);
File.WriteAllText(@"e:\temp\meuJSON.json", conteudoCore);

//Serializar com NewtonSoft
string conteudoNewtonSoft = JsonConvert.SerializeObject(listaPessoas);





var conteudoExemplo = File.ReadAllText(@"e:\temp\meuExemplo.json");
var classeLuizExemplo = System.Text.Json.JsonSerializer.Deserialize<ClasseLuiz>(conteudoExemplo);

ClasseLuiz classeLuizExemploNewtonSoft = JsonConvert.DeserializeObject<ClasseLuiz>(conteudoExemplo);










Console.ReadLine();