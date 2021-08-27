using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno " + nome + ": ");
            List<int> notas = new List<int>();
            int totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota número " + i + " :");
                int nota = int.Parse(Console.ReadLine());
                notas.Add(nota);
                totalNotas = totalNotas + nota;
            }
            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno " + nome + " é: " + media);
            Console.WriteLine("Suas notas são: \n");
            foreach (int nota in notas)
            {
                Console.WriteLine(nota);
            }
        }
    }
}
