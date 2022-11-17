using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploInterfaces.Contratos
{
    public interface IRepository<T, W>
    {
        void CriarNovo(T objeto);
        T ObterPorId(W id);
        T Atualizar(T myObj);
        void Apagar(W id);
    }
}
