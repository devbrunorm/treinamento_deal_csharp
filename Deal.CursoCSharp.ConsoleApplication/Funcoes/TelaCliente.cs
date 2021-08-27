using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("========== Cadastro de Clientes ==========");
            while (true) 
            {
                string mensagem = "Digite uma das opções abaixo:" +
                    "\n0 - Sair do cadastro" +
                    "\n1 - Para cadastrar clientes" +
                    "\n2 - Para listar clientes" + 
                    "\n====================";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var cliente = new Cliente();
                    Console.WriteLine("Digite o nome do cliente:");
                    cliente.SetNome(Console.ReadLine());
                    Console.WriteLine("Digite o telefone do cliente:");
                    cliente.SetTelefone(Console.ReadLine());
                    Console.WriteLine("Digite o CPF do cliente:");
                    cliente.SetCpf(Console.ReadLine());
                    cliente.Gravar();
                }
                else
                {
                    new Cliente().ExibirTodos();
                }
            }
        }
    }
}
