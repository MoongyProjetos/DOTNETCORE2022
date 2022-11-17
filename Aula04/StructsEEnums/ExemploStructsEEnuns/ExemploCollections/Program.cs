using ExemploCollections;

var turmaDotNet = new Turma();
var luiz = new Aluno { Nome="Luiz"};
var lais = new Aluno { Nome = "Lais" };
var etiene = new Aluno { Nome = "Etiene" };



Console.WriteLine("Exemplo Array");
turmaDotNet.AlunosArray = new Aluno[2];
turmaDotNet.AlunosArray[0] = luiz;
turmaDotNet.AlunosArray[1] = lais;
//turmaDotNet.Alunos[2] = etiene;

Console.WriteLine("Exemplo Lista");
turmaDotNet.AlunosList = new List<Aluno>();
turmaDotNet.AlunosList.Add(luiz);
turmaDotNet.AlunosList.Add(lais);
turmaDotNet.AlunosList.Add(lais);
turmaDotNet.AlunosList.Add(lais);
turmaDotNet.AlunosList.Add(lais);
turmaDotNet.AlunosList.Add(lais);
turmaDotNet.AlunosList.Add(etiene);

for (int i = 0; i < 1000; i++)
{
    if(i == 555)
    {
        turmaDotNet.AlunosList.Add(new Aluno { Nome = "Jonatas"});
    }
    else {
        turmaDotNet.AlunosList.Add(new Aluno());
    }
}

//Forma antiga
var existe = false;
var posicao = -1;
var contador = -1;
var contagem = 0;
foreach (var item in turmaDotNet.AlunosList)
{
    contador++;
    if(item != null && item.Nome == "Jonatas")
    {
        existe = true;
        posicao = contador;
    }

    if (item != null && item.Nome == "Lais")
    {
        contagem++;
    }
}


//LINQ
//Validar se o Jonatas existe
existe = turmaDotNet.AlunosList.Any(x => x.Nome == "Jonatas");

//Identificar a posicao
posicao = turmaDotNet.AlunosList.FindIndex(x => x.Nome == "Jonatas");

//Contar Nomes Repetidos
contagem = turmaDotNet.AlunosList.Count(x => x.Nome == "Lais");

//Listar os nomes em ordem reversa
var nomesEmOrdemReversa = turmaDotNet.AlunosList
    .OrderByDescending(x => x.Nome)
    .Where(x => !string.IsNullOrWhiteSpace(x.Nome))
    .Distinct()
    .ToList();


Console.WriteLine("Ordem reversa");
foreach (var item in nomesEmOrdemReversa)
{
    Console.WriteLine(item);
}






turmaDotNet.DicionarioDeAlunos = new Dictionary<int, string>();
turmaDotNet.DicionarioDeAlunos.Add(1, "Luiz");
turmaDotNet.DicionarioDeAlunos.Add(2, "Lais");
turmaDotNet.DicionarioDeAlunos.Add(99, "Jonatas");
turmaDotNet.DicionarioDeAlunos.Add(100, "Jonatas");

Console.WriteLine(turmaDotNet.DicionarioDeAlunos[99]);
Console.WriteLine(turmaDotNet.DicionarioDeAlunos[100]);





Console.ReadLine();