using ExemploInterfaces.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploInterfaces.Classes
{
    public class AlunoEspecial : IOperacoes, IDesconto
    {
        public string Limitacao { get; set; }

        public void AplicarDesconto(decimal valorDesconto)
        {
            throw new NotImplementedException();
        }

        public void Exemplo()
        {
            throw new NotImplementedException();
        }

        public void Recuperar()
        {
            throw new NotImplementedException();
        }

        public void Salvar()
        {
            throw new NotImplementedException();
        }

        bool IOperacoes.Exemplo()
        {
            throw new NotImplementedException();
        }
    }
}
