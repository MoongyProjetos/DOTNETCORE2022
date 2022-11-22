using ExemploHerancaFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerancaFramework.MyFramework
{
    public class MinhaListaCustomizada : List<Pessoa>
    {
        public void SortByName()
        {
            this.OrderBy(x => x.Nome).ThenBy(x => x.Id);
        }

        public void SortById()
        {
            this.OrderBy(x => x.Id).ThenByDescending(x=> x.Nome);
        }
    }
}
