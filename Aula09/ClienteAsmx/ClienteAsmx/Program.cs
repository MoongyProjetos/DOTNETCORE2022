using ClienteAsmx.ServicoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAsmx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            pessoa.Nome = "Paulo";
            pessoa.DataNascimento = new DateTime(2022, 12, 12);


            var cliente = new ServicoDeDados.PessoasServiceSoapClient();
            var resultado = cliente.ObterNomePessoaEmMaiusculo(pessoa);

            Console.WriteLine(resultado.Nome);
        }
    }
}
