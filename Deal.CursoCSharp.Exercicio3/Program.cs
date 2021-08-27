using System;

namespace Deal.CursoCSharp.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número entre 2 e 1000:");
            // Mais uma vez, temos que certificar o usuário informou um valor inteiro
            // Contudo, além de validar isso, devemos verificar se o número está entre 2 e 1.000
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 2 || numero > 1000)
                {
                    Console.WriteLine("Número inválido! Digite um número entre 2 e 1000.");
                }
                else
                {
                    for (int i = 1; i <= 10; i++) 
                    {
                        Console.WriteLine(i + " X " + numero + " = " + (i*numero));
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Valor inválido! O valor não é um número inteiro.");
            }
            Console.ReadKey();
        }
    }
}
