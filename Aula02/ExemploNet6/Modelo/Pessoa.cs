
using ModeloDoEndereco;

namespace Model
{
    public abstract class Pessoa 
    {
        public string? Nome { get; set; }
        public string? Nif { get; set; }
      
        // private int idade;
        // public int Idade
        // {
        //     get { 
                
        //         idade = DateTime.Now.Year - DataNascimento.Year;
        //         return idade;            
        //      }
        //     set { idade = value; }
        // }

        public int Idade => DateTime.Now.Year - DataNascimento.Year; //lambda expression //programação funcional com c#
        

        public char Sexo { get; set; }

        public DateTime DataNascimento { get; set; }

        public Endereco? Endereco { get; set; }

        public string? Historico {get;set;}
     
    }
}

