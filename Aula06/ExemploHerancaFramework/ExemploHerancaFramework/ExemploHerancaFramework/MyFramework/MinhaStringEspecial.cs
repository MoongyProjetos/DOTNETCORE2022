using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerancaFramework.MyFramework
{
    public static class MinhaStringEspecial
    {
        public static string ToNumeroContribuinte(this string valor)
        {
            //123456789
            if(valor.Length == 9)
            {
                var val1 = valor.Substring(0, 3);
                var val2 = valor.Substring(3, 3);
                var val3 = valor.Substring(6, 3);
                Console.WriteLine($"{val1}.{val2}.{val3}");
                return $"{val1}.{val2}.{val3}";
            }
              

            return "";
        }


        public static bool ValidarNif(this string valor)
        {
            Console.WriteLine($"{valor.Length == 9}");
            return valor.Length == 9;
        }
    }
}
