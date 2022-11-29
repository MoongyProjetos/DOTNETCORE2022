// See https://aka.ms/new-console-template for more information
using ExemploADO;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");



var connectionString = "Server=tcp:sqldb-learn-uks-001.database.windows.net,1433;Initial Catalog=sql-learn-uks-001;Persist Security Info=False;User ID=jonatas;Password=abc,1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


//ADOConnection
//ADOCommand


//CriarNovoAluno(connectionString);
//ObterTodosAlunos(connectionString);

ObterNomeAlunoFormaErrada(connectionString, "1; INSERT INTO Alunos (Nome) VALUES ('Invasor 2')"); //CUIDADO!!!
ObterNomeAlunoFormaMenosErrada(connectionString, "1; INSERT INTO Alunos (Nome) VALUES ('Invasor 3')");

//conexao.Close();
//string sql = "SELECT * FROM Alunos";
Console.ReadLine();




static void CriarNovoAluno(string connectionString)
{
    var conexao = new SqlConnection(connectionString);
    
    string sql = "INSERT INTO Alunos (Nome) Values ('Jonatas 02')";
    var comando = new SqlCommand(sql, conexao);

    using (conexao)
    {
        conexao.Open();
        var linhas = comando.ExecuteNonQuery();

        if (linhas > 0)
        {
            Console.WriteLine("Linha Inserida com sucesso");
        }
        else
        {
            Console.WriteLine("Ops, algo deu errado");
        }
    }
}


static List<Aluno> ObterTodosAlunos(string connectionString)
{
    var listagemAlunos = new List<Aluno>();

    using(var conexao = new SqlConnection(connectionString))
    {
        conexao.Open();
        string sql = "SELECT Id, Nome, DataNascimento FROM Alunos ORDER BY Nome, Id";
        var comando = new SqlCommand(sql, conexao);
        var resultados = comando.ExecuteReader();

        while (resultados.Read())
        {
            var aluno = new Aluno();
            aluno.Id = Convert.ToInt32(resultados[0].ToString());
            aluno.Nome = resultados[1].ToString();
            //aluno.DataNascimento = string.IsNullOrWhiteSpace(resultados[2].ToString()) == true ? null: DateTime.Parse(resultados[2].ToString());

            listagemAlunos.Add(aluno);
        }
    }

    return listagemAlunos;
}



static string ObterNomeAlunoFormaErrada(string connectionString, string id)
{
    var resultado = "";

    using (var conexao = new SqlConnection(connectionString))
    {
        conexao.Open();
        string sql = "SELECT Nome FROM Alunos WHERE Id = " + id; //Não fazer assim
        var comando = new SqlCommand(sql, conexao);
        resultado = comando.ExecuteScalar().ToString();
    }

    return resultado;
}


static string ObterNomeAlunoFormaMenosErrada(string connectionString, string id)
{
    var resultado = "";

    using (var conexao = new SqlConnection(connectionString))
    {
        conexao.Open();
        string sql = "SELECT Nome FROM Alunos WHERE Id = @id"; //Não fazer assim
        var comando = new SqlCommand(sql, conexao);
        comando.Parameters.AddWithValue("id", id);

        resultado = comando.ExecuteScalar().ToString();
    }

    return resultado;
}