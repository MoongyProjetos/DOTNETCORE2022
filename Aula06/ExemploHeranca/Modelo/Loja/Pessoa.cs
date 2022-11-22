using ExemploHeranca.Modelo.Banco;
using ExemploHeranca.Modelo.Operacoes;

namespace ExemploHeranca.Modelo.Loja
{
    public class Pessoa : IRepositorio<Pessoa>, IExibicao
    {
        #region Properties

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? NIF { get; set; }
        #endregion Properties

        #region Constructors
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa()
        {

        }
        #endregion Constructors

        #region Methods
        public virtual void Exibir()
        {
            Console.WriteLine("Exibir Pessoa");
        }

        public void Gravar(Pessoa meuObjeto)
        {
            Console.WriteLine("Gravar Pessoa");
        }
        #endregion Methods
    }
}