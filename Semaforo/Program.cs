using System;

namespace Semáforo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Responda com letras minusculas sem espaços");
            Console.WriteLine("Qual cor do farol está acesa?");
            string resposta = Console.ReadLine();
            if (resposta == "verde") {
                Console.WriteLine("Siga em frente");
            } else if (resposta == "amarelo") {
                Console.WriteLine("Preste atenção");
            } else if (resposta == "vermelho") {
                Console.WriteLine("Pare!");
            } else {
                Console.WriteLine("Resposta inválida");
            }
        }
    }
}
