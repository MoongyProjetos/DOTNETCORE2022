using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using WebApiExemploComplexoServer.Model;

namespace WebApiExemploComplexoServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private List<Pessoa> Pessoas;
        public PessoasController()
        {
            Pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "Joao", DataNascimento = new DateTime(1965, 01, 01) },
                new Pessoa { Nome = "Maria", DataNascimento = new DateTime(1985, 01, 01) }
            };
        }

        [HttpGet]
        [Route("ObterNome")]
        public string ObterNome(string nome)
        {
            return nome.ToUpper();
        }


        [HttpGet]
        public List<Pessoa> ListarPessoas()
        {
            return Pessoas;
        }


        [HttpPost]
        public void CriarPessoaEmMemoria(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }


        [HttpDelete]
        public void ApagarPessoaPorNome(string nome)
        {
            var pessoa = Pessoas.FirstOrDefault(x => x.Nome == nome);
            Pessoas.Remove(pessoa);
        }


        [HttpPut]
        public void AtualizarPessoaPorNome(Pessoa pessoa)
        {
            var resultado = Pessoas.FirstOrDefault(x => x.Nome == pessoa.Nome);
            resultado.Nome = pessoa.Nome.ToUpper();
        }


        [HttpPatch]
        public void AtualizarPessoa(string nome)
        {
            var pessoa = Pessoas.FirstOrDefault(x => x.Nome == nome);
            pessoa.Nome = pessoa.Nome.ToUpper();
        }
    }
}
