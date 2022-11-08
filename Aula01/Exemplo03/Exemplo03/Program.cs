using Biblioteca;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Exemplo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# parece com Java");



            Cliente maria = new Cliente();
            maria.Nome = "Maria da Silva";
            maria.IdentificacaoCliente = 1234;
            maria.DataNascimento = new DateTime(2000, 01, 01);


            Cliente joao = new Cliente
            {
                Nome = "Joao",
                DataNascimento = new DateTime(1999, 01, 01),
                IdentificacaoCliente = 4321
            };

            var pedro = new Cliente
            {
                Nome = "Pedro",
                DataNascimento = new DateTime(1998, 01, 01),
                IdentificacaoCliente = 321
            };

            Console.WriteLine("O Pedro nasceu em:" + pedro.DataNascimento);


            Console.ReadLine();

        }
    }
}
