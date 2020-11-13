using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faca um programa que receba a idade de um nadador e imprima sua categoria
            //Cateoria          idade
            //infantil A        5 a 7 anos
            //infantil B        8 a 10 anos
            //Juvenil A         11 a 13 anos
            //Juvenil B         14 a 17 anos
            //Senior            maior de 18

            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            //Eu sei que seria mais facil com if encadeado, mas vou fazer sem
            if (idade >= 18) {
                Console.WriteLine("Você está apto para a categoria Sênior");
            } else {
                if (idade >= 14){
                    Console.WriteLine("Você esta apto para a categoria Juvenil B");
                } else {
                    if (idade >= 11) {
                        Console.WriteLine("Você está apto para a categoria Juvenil A");
                    } else {
                        if (idade >= 8) {
                        Console.WriteLine("Você está apto para a categoria Infantil B");
                        } else {
                            if (idade >= 5){
                                Console.WriteLine("Você está apto para a categoria Infantil A");
                            }
                            else {
                                Console.WriteLine("Você e novo demais para ter categoria");
                            }
                        }
                    } 
                }
            }
        }
    }
}
