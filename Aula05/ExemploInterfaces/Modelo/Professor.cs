
using ExemploInterfaces.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploInterfaces.Modelo
{
    internal class Professor : IRepository<Professor, int>
    {
        public void Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Professor Atualizar(Professor myObj)
        {
            throw new NotImplementedException();
        }

        public void CriarNovo(Professor objeto)
        {
            throw new NotImplementedException();
        }

        public Professor ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
