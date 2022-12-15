using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerceiroExemplo.Modelo;

namespace TerceiroExemplo.CamadaLogica
{
    public class PessoaManager
    {
        private readonly List<Pessoa> pessoaList;

        public PessoaManager()
        {
            pessoaList = new List<Pessoa>();
            for (int i = 0; i < 100000; i++)
            {
                pessoaList.Add(new Pessoa { Id = i, Nome = $"Pessoa{i}" });
            }
        }

        public async Task<List<Pessoa>> ObterPessoas() => pessoaList;

        public async Task<int> ObterPosicaoPessoa(string nome)
        {
            for (int i = 0; i < pessoaList.Count; i++)
            {
                if (pessoaList[i].Nome == nome)
                {
                    return i;
                }
            }

            return -1;
        }


        public async Task<Pessoa> ObterPessoaNaPosicao(int posicao)
        {
            return pessoaList[posicao];
        }


        public async Task AdicionarPessoa(Pessoa p)
        {
            pessoaList.Add(p);
        }

    }
}
