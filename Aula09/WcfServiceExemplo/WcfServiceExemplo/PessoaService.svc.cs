using System;
using System.Collections.Generic;
using System.Linq;

namespace WcfServiceExemplo
{
    public class PessoaService : IPessoaService
    {
        public Pessoa ObterPessoaPorNome(string nome)
        {
            var listaPessoas = new List<Pessoa>
            {
                new Pessoa {Nome = "Joao", DataNascimento = new DateTime(1965,01,01)},
                new Pessoa {Nome = "Maria", DataNascimento = new DateTime(1985,01,01)},
            };

            return listaPessoas.FirstOrDefault(x => x.Nome == nome);
        }
    }
}
