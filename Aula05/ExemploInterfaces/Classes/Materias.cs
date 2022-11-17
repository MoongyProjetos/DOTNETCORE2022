using ExemploInterfaces.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploInterfaces.Classes
{
    public class Materias : IOperacoes, IDesconto
    {
        public void AplicarDesconto(decimal valorDesconto)
        {
            throw new NotImplementedException();
        }

        public void Recuperar()
        {
            Console.WriteLine("Recuperei Materias");
        }

        public void Salvar()
        {
            Console.WriteLine("Escrevi Materias");
        }
    }
}
