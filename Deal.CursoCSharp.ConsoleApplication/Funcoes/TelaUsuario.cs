using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("========== Cadastro de Usuários ==========");
            while (true) 
            {
                string mensagem = "Digite uma das opções abaixo:" +
                    "\n0 - Sair do cadastro" +
                    "\n1 - Para cadastrar usuários" +
                    "\n2 - Para listar usuários" + 
                    "\n====================";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var usuario = new Usuario();
                    Console.WriteLine("Digite o nome do usuário:");
                    usuario.SetNome(Console.ReadLine());
                    Console.WriteLine("Digite o telefone do usuário:");
                    usuario.SetTelefone(Console.ReadLine());
                    Console.WriteLine("Digite o CPF do usuário:");
                    usuario.SetCpf(Console.ReadLine());
                    usuario.Gravar();
                }
                else
                {
                    new Cliente().ExibirTodos();
                }
            }
        }
    }
}
