using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    public class Cliente : Base
    {
        public string Nome;
        public string Telefone;
        public string CPF;

        public Cliente(string _nome, string _telefone, string _cpf)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _cpf;
        }

        public Cliente() {}
    }
}
