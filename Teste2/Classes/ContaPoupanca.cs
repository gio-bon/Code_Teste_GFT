namespace Teste2.Classes
{
    public class ContaPoupanca : Conta
    {
        public override double Rendimento()
        {
            return this.Saldo * 1.07;
        }

        public ContaPoupanca(int numero, string titular, double saldo) : base(numero, titular,saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}