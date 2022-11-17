using ExemploClasses.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasses.ClassesEstaticas
{
    public static class Impressora
    {
        public static void Imprimir(Pessoa p)
        {
            Console.WriteLine(p.Nome);
            File.WriteAllText(@"e:\temp\exemplo.txt", p.Nome);
        }
    }
}
