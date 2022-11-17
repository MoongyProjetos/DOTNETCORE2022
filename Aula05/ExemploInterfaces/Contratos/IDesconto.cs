using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploInterfaces.Contratos
{
    public interface IDesconto
    {
        void AplicarDesconto(decimal valorDesconto);
        void Exemplo();
    }
}
