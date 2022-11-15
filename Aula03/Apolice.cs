public class Apolice
{
    public int valor { get; set; }
}

class CalculadoraDeApolice
{
    public int Somar(Apolice[] pol1)
    {
        var resultado = 0;

        foreach (var item in pol1)
        {
            if (item != null)
            {
                resultado += item.valor;
            }
        }

        return resultado;
    }

    public Apolice ObterApolice()
    {
        return new Apolice();
    }


    public void Exemplo()
    {

    }


    public void Exemplo(int a)
    {
        if (a == 1)
        {
            System.Console.WriteLine("sdsfds");
        }
        else
        {
            System.Console.WriteLine("");
        }
    }


    public void ExemploIfInvertido(int a)
    {
        if (a != 1)
        {
            System.Console.WriteLine("");
            return; //GuardClausule
        }

        System.Console.WriteLine("sdsfds");
    }


    public static void ExemploPorReferencia(ref string a)
    {
        System.Console.WriteLine(a);
        a += " opa, passei aqui";
    }


    public void Vai(string a)
    {
        ///
    }

    public static void Vai(string a, string b)
    {
        ///
    }

public static int Vai(string a, string b, out string c, out PessoaDto pessoa)
    {
        c = "valor transformado";
        pessoa = new PessoaDto{};

        return 10;
    }

    public static void Vai(string a, string b, string c, string d = "valor")
    {
        ///
    }


    public void ValidarPessoa(string nome)
    {

    }

    public void ValidarPessoa(PessoaDto pessoa)
    {
        //SPDB0029 - Tabela Clientes ... 255
        //SDPB0035 - Tabela de Seguros

        //sobrenome ...
        //SPDB0029_ESP ... 56 


        //char(25) : Valor
        decimal variavelDoDiego = 10M;
        float variavelDoLuiz = 10;

        string CsvDoGoverno = "R$ 10.000,00";


        string CsvEmDolar = "US$ 10,000.00";
    }
}
