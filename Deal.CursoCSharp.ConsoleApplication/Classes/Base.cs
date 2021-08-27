using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    public class Base : IPessoa
    {
        public string Nome;
        public string Telefone;
        public string CPF;

        private string sobrenome = "Santos";

        public void SetNome(string nome) 
        {
            this.Nome = nome;
        }
        public void SetTelefone(string telefone) 
        {
            this.Telefone = telefone;
        }
        public void SetCpf(string cpf) 
        {
            this.CPF = cpf;
        }

        protected int CalcularUmMaisDois()
        {
            return 1 + 2;
        }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="_nome">Nome da Pessoa</param>
        /// <param name="_telefone">Telefone da Pessoa</param>
        /// <param name="_cpf">CPF da Pessoa</param>
        public Base(string _nome, string _telefone, string _cpf)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _cpf;
        }

        public Base() { }

        public string diretorioComArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
        }

        public virtual void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);

            if (File.Exists(diretorioComArquivo()))
            {
                StreamWriter r = new StreamWriter(diretorioComArquivo());
                string conteudo = "nome;telefone;cpf;";
                r.WriteLine(conteudo);
                foreach (Base b in dados)
                {
                    var linha = b.Nome + ";" + b.Telefone + ";" + b.CPF + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
        }

        public virtual List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(diretorioComArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioComArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');
                        var b = (IPessoa)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCpf(baseArquivo[2]);
                        dados.Add(b);
                    };
                }
            }
            return dados;
        }

        public void Olhar()
        {
            Console.WriteLine("O usuário " + this.Nome + " está olhando para mim.");
            this.Olhar();
        }

        public new void ExibirTodos()
        {
            var dados = this.Ler();
            foreach (Base b in dados)
            {
                Console.WriteLine("Nome: " + b.Nome);
                Console.WriteLine("Telefone: " + b.Telefone);
                Console.WriteLine("CPF: " + b.CPF);
                Console.WriteLine("\n");
                Console.WriteLine("====================");
            }
        }
    }
}
