using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faca um programa que recebe a idade de uma pessoa e imprima ela em meses, dias, horas e minutos

            Console.WriteLine("Digite sua idade");
            int anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Você tem:");
            Console.WriteLine(anos * 12 + " meses de vida");
            Console.WriteLine(anos * 12 * 30 + " dias de vida");
            Console.WriteLine(anos * 12 * 30 * 24 + " horas de vida");
            Console.WriteLine(anos * 12 * 30 * 24 * 60 + " minutos de vida");
        }
    }
}
