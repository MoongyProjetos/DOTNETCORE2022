using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploStructsEEnums.Model.Estruturas
{
    public struct Endereco
    {
        public string? Rua { get; set; }
        public string? CodigoPostal { get; set; }


        //Endereco()

        public Endereco(string rua)
        {
            Rua = rua;
            CodigoPostal = null;
        }
    }
}
