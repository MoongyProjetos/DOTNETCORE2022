using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExemploStructsEEnums.Model.Classes
{
    public class Pessoa
    {
        #region Properties
        public int Id { get; set; }
        public string Nome { get; set; }
        #endregion Properties


        #region Constructors
        public Pessoa()
        {

        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }


        public Pessoa(string nome, int id)
        {
            Id = id;
            Nome = nome.ToUpper();
        }

        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome.ToLower();
        }
        #endregion Properties



    }
}
