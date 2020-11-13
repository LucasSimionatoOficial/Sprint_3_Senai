using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reajuste o valor do salario de um funcionario, que se for menor que 500, eve aumentar em 30%

            Console.WriteLine("insira seu salario");
            double salario = double.Parse(Console.ReadLine());
            if (salario < 500) {
                salario = salario * 1.3;
                Console.WriteLine("Seu salario foi reajustado para " + salario + "reais");
            } else {
                Console.WriteLine ("Seu salario não foi reajustado");
            }
        }
    }
}
