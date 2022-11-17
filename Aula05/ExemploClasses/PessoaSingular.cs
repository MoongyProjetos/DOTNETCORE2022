using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasses.Pessoas
{
    public class PessoaSingular : Pessoa
    {
        public void Exemplo2()
        {
            MinhaPropriedadeProtegida = 10;
            MinhaPropriedadeInterna = 10;
        }
    }
}
