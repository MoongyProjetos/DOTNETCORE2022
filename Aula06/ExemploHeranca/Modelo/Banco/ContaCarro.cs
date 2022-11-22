namespace ExemploHeranca.Modelo.Banco
{
    //FINAL: JAVA
    public sealed class ContaCarro : Conta
    {
        public string? MatriculaCarro { get; set; }
        public void PagarPrestacoes() { }

        public double CalcularSaldo() => 0.5;//Formula de cálculo para carros

        public override double CalcularSaldoAbstrato()
        {
            MetodoHerdavel();
            Console.WriteLine("Calcular Saldo Abstrato ContaCarro");
            return 0.2;
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