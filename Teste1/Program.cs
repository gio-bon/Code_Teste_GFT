using System;
using Teste1.Classes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario giovani = new Funcionario();
            giovani.Salario = 5000;
            giovani.receberAumento(500);


            Console.WriteLine(giovani.calcularGanhoBrutoAnual());
            //Console.WriteLine(giovani.calcularGanhoBrutoAnual());
        }
    }
}