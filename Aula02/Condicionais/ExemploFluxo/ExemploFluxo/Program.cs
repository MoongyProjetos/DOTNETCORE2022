using ExemploFluxo;

var john = new Pessoa();
john.Nome = "John Doe";
john.Sexo = "F";

if (john.Sexo == "M")
{
    Console.WriteLine($"Bem vindo {john.Nome}");
}
else
{
    if (john.Sexo == "F")
    {
        Console.WriteLine($"Bem vinda {john.Nome}");
    }
    else
    {
        Console.WriteLine($"Olá {john.Nome}");
    }
}



var mary = new Pessoa();
mary.Nome = "Mary Shelley";
mary.Sexo = "F";
mary.Idade = 18;

//Até 11 anos crianca
//Até 17 anos adolescente
//Até 50 adulto
//Até 70 meia idade
//Depois idoso

switch (mary.Idade)
{
    case 11:
        Console.WriteLine("Crianca");
        break;
    case 17:
        Console.WriteLine("Adolescente");
        break;
    case 50:
        Console.WriteLine("Adulto");
        break;
    case 70:
        Console.WriteLine("Meia idade");
        break;
    default:
        Console.WriteLine("Idoso");
        break;
}

if(mary.Idade >= 0 && mary.Idade <= 11){ Console.WriteLine("Crianca"); }

if (mary.Idade >= 12 && mary.Idade <= 17) { Console.WriteLine("Adolescente"); }


if(mary.Idade >= 70 || mary.Idade >= 80)
{

}

var resultado = mary.Idade >= 70 ? "Dinossauro": "Crianca";


    Console.ReadLine();

