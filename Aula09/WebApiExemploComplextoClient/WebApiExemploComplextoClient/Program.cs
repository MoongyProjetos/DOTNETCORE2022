// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.Json;
using WebApiExemploComplextoClient.Modelo;

Console.WriteLine("Hello, World!");

var cliente = new HttpClient();
cliente.BaseAddress = new Uri("https://localhost:7196/");

ObterNomeCliente(cliente);
ObterListagemPessoasString(cliente);
ObterListagemPessoasToList(cliente);
CriarClientePost(cliente);



Console.ReadLine();

static void ObterNomeCliente(HttpClient cliente)
{
    var resultado = cliente.GetAsync("api/Pessoas/ObterNome?nome=Joao").Result;

    Console.WriteLine("Headers");
    Console.WriteLine(resultado);
    Console.WriteLine("Conteudo");
    Console.WriteLine(resultado.Content.ReadAsStringAsync().Result);
}



static void ObterListagemPessoasString(HttpClient cliente)
{
    var resultadoListarPessoas = cliente.GetAsync("api/Pessoas").Result;
    Console.WriteLine("Headers");
    Console.WriteLine(resultadoListarPessoas);
    Console.WriteLine("Conteudo");
    Console.WriteLine(resultadoListarPessoas.Content.ReadAsStringAsync().Result);
}




static void ObterListagemPessoasToList(HttpClient cliente)
{
    var resultadoListarPessoas = cliente.GetAsync("api/Pessoas").Result;
    Console.WriteLine("Headers");
    Console.WriteLine(resultadoListarPessoas);
    Console.WriteLine("Conteudo");
    var conteudoJson = resultadoListarPessoas.Content.ReadAsStringAsync().Result;

    var option = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    var listaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(conteudoJson, option);

    Console.WriteLine(listaPessoas.Count);
}





static void CriarClientePost(HttpClient cliente)
{
    var content = new StringContent("{\r\n  \"nome\": \"Paulo\",\r\n  \"dataNascimento\": \"2022-12-12T21:00:05.716Z\"\r\n}", Encoding.UTF8, "application/json");
    var resultadoListarPessoas = cliente.PostAsync("api/Pessoas", content).Result;
    Console.WriteLine("Headers");
    Console.WriteLine(resultadoListarPessoas);
}