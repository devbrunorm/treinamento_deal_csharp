using System;

namespace Deal.CursoCSharp.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            // O número digitado deverá ser inteiro, pois par e ímpar são validações de existem apenas nos números inteiros.
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 1)
                {
                    Console.WriteLine("O número " + numero + " é um número ímpar");
                }
                else
                {
                    Console.WriteLine("O número " + numero + " é um número par");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("O valor digitado não é um número inteiro");
            }
            Console.ReadKey();
        }
    }
}
