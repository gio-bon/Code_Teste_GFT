using System;
using Teste2.Classes;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorr1 = new ContaCorrente(555, "Giovani", 10000);
            ContaPoupanca contaPoup1 = new ContaPoupanca(666, "Bontempo", 5000);

            Console.WriteLine(contaCorr1.Saldo);
            Console.WriteLine(contaCorr1.Titular);
            Console.WriteLine(contaPoup1.Saldo);
            Console.WriteLine(contaPoup1.Titular);

            Console.WriteLine(contaCorr1.Rendimento());
            Console.WriteLine(contaPoup1.Rendimento());
        }
    }
}