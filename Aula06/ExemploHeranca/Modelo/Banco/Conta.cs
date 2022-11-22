using ExemploHeranca.Modelo.Operacoes;

namespace ExemploHeranca.Modelo.Banco
{
    public abstract class Conta : IRepositorio<Conta>, IExibicao
    {
        public string? IBAN { get; set; }
        public string? CodigoFinancas { get; set; }

        public double CalcularSaldoComumParaTodos() => 0;//Formula de cálculo

        public abstract double CalcularSaldoAbstrato(); //obriga os filhos a implementar

        public virtual double CalcularSaldoVirtual() //Caso queira usar na maior parte dos casos, posso usar um virtual
        {
            //NÃO FAZER ASSIM. RISCO DE MORTE E INFERNO CERTO!!!
            //if(this.GetType() == typeof(ContaCorrente))
            //    return 97;

            //if (this.GetType() == typeof(ContaCarro))
            //    return 96;

            return 99;
        }


        protected void MetodoHerdavel() { }


        public void Gravar(Conta meuObjeto)
        {
            Console.WriteLine("Gravar Conta");
        }

        public void Exibir()
        {
            Console.WriteLine("Exibir Conta");
        }
    }
}







//ContaPoupanca
//----Identificacao - IBAN
//----Código nas Financas 
//----Operacoes: //Acrescimo dos jurps
//ContaCarro
//----Identificacao - IBAN
//----Código nas Financas
//----Operacoes: Pagamentos das prestacoes