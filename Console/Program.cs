using System;

namespace console_1
{
    class Program
    {
        static void Main(string[] args)
        {
                //Bem vindo seu nome
            Console.WriteLine("Digite seu nome");
            string name = Console.ReadLine();
            Console.WriteLine("Bem vindo "+ name);

                //Cálculo de Soma
            Console.WriteLine("Digite o primeiro número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());
            //supondo que apenas números inteiros foram digitados
            int soma = a + b;
            // Console.Write("O resultado é: ");
            // Console.WriteLine(soma);
            Console.WriteLine("O resultado de " + a + " + " + b + " é: " + soma);
        }
    }
}
