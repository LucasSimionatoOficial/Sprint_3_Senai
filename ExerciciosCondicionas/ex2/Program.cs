using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba o ano de nascimento e o atual, e depois calcule e imprima a idade em anos e em semanas

            Console.WriteLine("Digite o ano que você nasceu");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora o ano que estamos");
            int esse = int.Parse(Console.ReadLine());
            Console.WriteLine("você tem " + (esse - ano) + " anos ou " + ((esse - ano) * 365 / 7) + " semanas de vida");
        }
    }
}
