using ExemploInterfaces.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploInterfaces.Modelo
{
    internal class Diretor : IRepository<Diretor, Guid>
    {
        public void Apagar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Diretor Atualizar(Diretor myObj)
        {
            throw new NotImplementedException();
        }

        public void CriarNovo(Diretor objeto)
        {
            throw new NotImplementedException();
        }

        public Diretor ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
