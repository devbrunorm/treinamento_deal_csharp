using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("========== Cadastro de Fornecedores ==========");
            while (true) 
            {
                string mensagem = "Digite uma das opções abaixo:" +
                    "\n0 - Sair do cadastro" +
                    "\n1 - Para cadastrar fornecedores" +
                    "\n2 - Para listar fornecedores" + 
                    "\n====================";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var fornecedor = new Fornecedor();
                    Console.WriteLine("Digite o nome do fornecedor:");
                    fornecedor.SetNome(Console.ReadLine());
                    Console.WriteLine("Digite o telefone do fornecedor:");
                    fornecedor.SetTelefone(Console.ReadLine());
                    Console.WriteLine("Digite o CPF do gerente:");
                    fornecedor.SetCpf(Console.ReadLine());
                    Console.WriteLine("Digite o CNPJ do fornecedor:");
                    fornecedor.SetCnpj(Console.ReadLine());
                    fornecedor.Gravar();
                }
                else
                {
                    new Cliente().ExibirTodos();
                }
            }
        }
    }
}
