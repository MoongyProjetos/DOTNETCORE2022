namespace ExemploHeranca.Modelo.Banco
{
    public class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }
        private double DepreciarJuros()
        {
            return 1;
        }

        public void AcrescentarJuros() { }

        public override double CalcularSaldoAbstrato()
        {
            Console.WriteLine("Calcular Saldo Abstrato ContaCorrente");
            return 0.1 * TaxaJuros * DepreciarJuros();
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