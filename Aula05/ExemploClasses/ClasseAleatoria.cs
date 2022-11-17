using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasses.Pessoas
{
    internal class ClasseAleatoria //package
    {
        public ClasseAleatoria()
        {
            var pessoa = new Pessoa();
            pessoa.MinhaPropriedadeInterna = 10;
        }

        //~ClasseAleatoria()
        //{
        //    //log.
        //}
    }
}
