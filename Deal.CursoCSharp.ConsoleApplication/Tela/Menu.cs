using System;
using System.Collections.Generic;
using System.Text;
using Calculo;
using Diretorio;
using Funcoes;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABAUDA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIOS = 5;
        public const int CADASTRAR_FORNECEDORES = 6;
        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\nAplicação Console Final" +
                    "\nDigite uma das opções abaixo:" +
                    "\n0 - Sair do programa" +
                    "\n1 - Para Ler arquivos" +
                    "\n2 - Para executar a tabuada" +
                    "\n3 - Calcular média de alunos" + 
                    "\n4 - Cadastrar clientes" +
                    "\n5 - Cadastrar usuários" +
                    "\n6 - Cadastrar fornecedores";
                Console.WriteLine(mensagem);

                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("==============================\n");
                    Arquivo.Ler(1);
                    Console.WriteLine("==============================\n");
                }
                else if (valor == TABAUDA)
                {
                    Console.WriteLine("==============================\n");
                    Console.WriteLine("Digite o número que deseja na tabuada:");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("==============================\n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("==============================\n");
                    Media.Aluno();
                    Console.WriteLine("==============================\n");
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    Console.WriteLine("==============================\n");
                    TelaCliente.Chamar();
                    Console.WriteLine("==============================\n");
                }
                else if (valor == CADASTRAR_USUARIOS)
                {
                    Console.WriteLine("==============================\n");
                    TelaUsuario.Chamar();
                    Console.WriteLine("==============================\n");
                }
                else if (valor == CADASTRAR_FORNECEDORES)
                {
                    Console.WriteLine("==============================\n");
                    TelaFornecedor.Chamar();
                    Console.WriteLine("==============================\n");
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente");
                }
            }
        }
    }
}
