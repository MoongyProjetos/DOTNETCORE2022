using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca.Modelo.Loja
{
    public class Cliente : Pessoa
    {
        public string? MyProperty { get; set; }

        public Cliente(string? nomeEspecifico, string? minhaPropriedade):base(nomeEspecifico)
        {
            MyProperty = minhaPropriedade;            
        }

        public override void Exibir()
        {
            Console.WriteLine("Comporamento da classe filha");
            base.Exibir(); //Comportamento do Pai/da Mae
        }
    }
}
