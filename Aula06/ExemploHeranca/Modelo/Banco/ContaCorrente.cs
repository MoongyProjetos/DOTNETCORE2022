namespace ExemploHeranca.Modelo.Banco
{
    public class ContaCorrente : Conta
    {
        public override double CalcularSaldoAbstrato()
        {
            Console.WriteLine("Calcular Saldo Abstrato ContaCorrente");
            return 0.1;
        }

        public override double CalcularSaldoVirtual()
        {
            Console.WriteLine("Calcular Saldo Virtual ContaCorrente");
            return 97;
        }

        public void EfetuarDebito() { }
        public void EfetuarDeposito() { }
        public void EmitirCartao() { }
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