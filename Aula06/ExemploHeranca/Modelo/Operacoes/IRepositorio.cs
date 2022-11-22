using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca.Modelo.Operacoes
{
    public interface IRepositorio<T>
    {
        public void Gravar(T meuObjeto);
    }
}
