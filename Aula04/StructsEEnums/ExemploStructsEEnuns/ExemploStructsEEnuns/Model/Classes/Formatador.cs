using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploStructsEEnums.Model.Classes
{
    public static class Formatador
    {
        public static string ConverterPrimeiraLetraParaMaiusculas(this string minhaVar)
        {
            var resultado = minhaVar[0].ToString().ToUpper() + minhaVar.Substring(1,minhaVar.Length-1);
            return resultado;
        }
    }
}
