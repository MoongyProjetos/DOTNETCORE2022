using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using TerceiroExemplo.CamadaLogica;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Inicio Aplicacao");

        Console.WriteLine("Task com result: ");
        Console.WriteLine(ObterResultado().Result);

        var pessoaMgr = new PessoaManager();

        var listaImpressao = pessoaMgr.ObterPessoas().Result.Take(10);
        foreach (var item in listaImpressao)
        {
            Console.WriteLine(item.ToString());
        }


        var posicao = pessoaMgr.ObterPosicaoPessoa("Pessoa99999").Result;
        Console.WriteLine(posicao);


        var posicao2  = await pessoaMgr.ObterPosicaoPessoa("Pessoa99999");
        Console.WriteLine(posicao);


        //ExecucaoEmParalelo();


        Console.WriteLine("Final Aplicacao");
        Console.ReadLine();
    }

    private static void ExecucaoEmParalelo()
    {
        Parallel.Invoke(
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\primeiro.txt"),
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\segundo.txt"),
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\terceiro.txt"),
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\quarto.txt")
        );
        //  Thread.Sleep(2000);

        Parallel.Invoke(
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\primeiro2.txt"),
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\segundo2.txt"),
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\terceiro2.txt"),
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\quarto2.txt")
        );
        //  Thread.Sleep(2000);


        Parallel.Invoke(
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\primeiro3.txt"),
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\segundo3.txt"),
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\terceiro3.txt"),
            () => CriarArquivo(@"E:\Formacoes\Moongy\DOTNETCORE2022\Aula10\TerceiroExemplo\quarto3.txt")
        );
        // Thread.Sleep(2000);
    }

    public static async Task<string> ObterResultado()
    {
        return "meu resultado";
    }

    public static async Task CriarArquivo(string path)
    {
        Console.WriteLine($"Execucao da Task: {DateTime.Now}");
        Console.WriteLine(path);
        File.AppendAllTextAsync(path, $"{DateTime.Now}");
    }


    public static void ExecutarCoisasEmParalelo(int quantidade)
    {
        var minhaLista = new List<string>();
        for (int i = 0; i < quantidade; i++)
        {
            minhaLista.Add("Novo Elemetno");
        }

        foreach (var item in minhaLista)
        {
            Console.WriteLine(item);
        }
    }


    public async Task FinalizarProcesso(Action callback)
    {
        Console.WriteLine("Terminei Thread");
    }
}