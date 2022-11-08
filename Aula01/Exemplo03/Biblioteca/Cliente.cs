using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int IdentificacaoCliente { get; set; }
        public DateTime DataNascimento { get; set; }


        public Cliente()
        {

        }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public Cliente(string nome, int identificacaoCliente) 
        {
            IdentificacaoCliente = identificacaoCliente;
            Nome = nome;
        }
    }
}


