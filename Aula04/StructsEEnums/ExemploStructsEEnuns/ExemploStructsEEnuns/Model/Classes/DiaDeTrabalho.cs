using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploStructsEEnums.Model.Enumeradores;

namespace ExemploStructsEEnums.Model.Classes
{
    public class DiaDeTrabalho
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public bool EhFeriado { get; set; }

        public DiasDaSemana diaDaSemana { get; set; }
    }
}
