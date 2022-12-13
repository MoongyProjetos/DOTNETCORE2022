using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cliente = new MeuServicoWCF.Service1Client();
                        var resultado = cliente.GetData(1);
            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}
