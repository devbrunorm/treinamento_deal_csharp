using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    public class Fornecedor : Base
    {
        public string CNPJ;
        public string Nome;
        public string Telefone;
        public string CPF;

        public void SetCnpj(string cnpj)
        {
            this.CNPJ = cnpj;
        }

        public Fornecedor(string _nome, string _telefone, string _cpf,string _cnpj)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _cpf;
            this.CNPJ = _cnpj;
        }

        public Fornecedor() {}

        public override void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);

            if (File.Exists(diretorioComArquivo()))
            {
                StreamWriter r = new StreamWriter(diretorioComArquivo());
                string conteudo = "nome;telefone;cpf;cnpj;";
                r.WriteLine(conteudo);
                foreach (Fornecedor f in dados)
                {
                    var linha = f.Nome + ";" + f.Telefone + ";" + f.CPF + ";" + f.CNPJ + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
        }

        public override List<IPessoa> Ler()
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
                        var b = (Fornecedor)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCpf(baseArquivo[2]);
                        b.SetCnpj(baseArquivo[3]);
                        dados.Add(b);
                    };
                }
            }
            return dados;
        }
    }
}
