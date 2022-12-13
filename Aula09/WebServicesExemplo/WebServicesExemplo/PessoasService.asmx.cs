using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesExemplo
{
    /// <summary>
    /// Summary description for PessoasService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PessoasService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public string ConverterParaMaiusculas(string nome)
        {
            return nome.ToUpper();
        }

        [WebMethod]
        public Pessoa ObterPessoaPorNome(string nome)
        {
            var listaPessoas = new List<Pessoa>();
            listaPessoas.Add(new Pessoa { Nome = "Joao", DataNascimento = new DateTime(1965, 01, 01) });
            listaPessoas.Add(new Pessoa { Nome = "Maria", DataNascimento = new DateTime(1984, 01, 01) });


            return listaPessoas.FirstOrDefault(x => x.Nome == nome);
        }

        [WebMethod]
        public Pessoa ObterNomePessoaEmMaiusculo(Pessoa pessoa)
        {
            var resultado = new Pessoa();
            resultado.Nome = pessoa.Nome.ToUpper();
            resultado.DataNascimento = pessoa.DataNascimento;

            return resultado;
        }

    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
