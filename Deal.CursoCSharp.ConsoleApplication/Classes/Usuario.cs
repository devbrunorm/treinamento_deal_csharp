using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    public class Usuario : Base
    {
        public Usuario(string _nome, string _telefone, string _cpf)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _cpf;
        }

        public Usuario() { }
    }
}
