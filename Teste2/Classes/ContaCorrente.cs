namespace Teste2.Classes
{
    public class ContaCorrente : Conta
    {

        public override double Rendimento()
        {
            return this.Saldo * 1.05;
        }

        public ContaCorrente(int numero, string titular, double saldo) : base(numero, titular,saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}