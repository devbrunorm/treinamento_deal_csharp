using System;

namespace Deal.CursoCSharp.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma idade em anos:");
            // Novamente, o valor informado deve ser um número inteiro
            try
            {
                int idade = Convert.ToInt32(Console.ReadLine());
                if (idade < 18)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sem permissão");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Permissão concedida");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (Exception e)
            {
                Console.WriteLine("O valor de idade inválido!");
            }
            Console.ReadKey();
        }
    }
}
