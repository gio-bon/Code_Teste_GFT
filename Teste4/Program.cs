using System;
using Teste4.Classes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora operacoes = new Calculadora();
            Console.WriteLine(operacoes.Soma(20, 10));
            Console.WriteLine(operacoes.Subtracao(20, 10));
            Console.WriteLine(operacoes.Divisao(20, 10));
            Console.WriteLine(operacoes.Multiplicacao(20, 10));

            Console.WriteLine(operacoes.Soma(198, 99));
            Console.WriteLine(operacoes.Subtracao(198, 99));
            Console.WriteLine(operacoes.Divisao(198, 99));
            Console.WriteLine(operacoes.Multiplicacao(198, 99));

            Console.WriteLine(operacoes.Soma(11549, 9284));
            Console.WriteLine(operacoes.Subtracao(11549, 9284));
            Console.WriteLine(operacoes.Divisao(11549, 9284));
            Console.WriteLine(operacoes.Multiplicacao(11549, 9284));

            Console.WriteLine(operacoes.Soma(99999, 9));
            Console.WriteLine(operacoes.Subtracao(99999, 9));
            Console.WriteLine(operacoes.Divisao(99999, 9));
            Console.WriteLine(operacoes.Multiplicacao(99999, 9));
            
        }
    }
}