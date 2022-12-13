using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiExemploComplextoClient.Modelo
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo sexo { get; set; }
        public int Idade => DateTime.Now.Year - DataNascimento.Year; 
    }

    public enum Sexo
    {
        Indefinido,
        Masculino,
        Feminino
    }
}
