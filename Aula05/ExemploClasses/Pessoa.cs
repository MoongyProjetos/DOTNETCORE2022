using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasses.Pessoas
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        private int Idade { get; set; }

        protected int MinhaPropriedadeProtegida { get; set; }
        internal int MinhaPropriedadeInterna { get; set; }



        public void Exemplo()
        {
            MinhaPropriedadeProtegida = 10;
            MinhaPropriedadeInterna = 10;
        }



        public void InformarIdade(DateTime datanascimento)
        {
            Idade = DateTime.Today.Year - datanascimento.Year;
        }

        //package - Internal


        public static void ExemploMetodoEstatico()
        {

        }
    }
}
