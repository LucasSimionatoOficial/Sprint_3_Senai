using System;

namespace Exclui
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para participar do time o aluno precisa de nota maior ou igual a 80 e faltas menor ou igual a 10% dias letivos
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Você quer participar?");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");
            string a = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");
            if (a == "sim") {
                Console.WriteLine("Legal, vamos ver se você pode");
                Console.WriteLine("Manda sua media");
                Console.WriteLine("---------------------------------------------");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Agora as faltas");
                Console.WriteLine("---------------------------------------------");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");
                if (b >=50 && c <=10){
                    Console.WriteLine("Parabens, voce passou");
                } else {
                    Console.WriteLine("Falte menos e tire boas notas");
                    Console.WriteLine("Passar bem");
                }
            } else {
                Console.WriteLine("Passar bem");
            }
            Console.WriteLine("---------------------------------------------");
        }
    }
}
