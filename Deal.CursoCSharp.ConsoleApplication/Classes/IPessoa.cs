using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public interface IPessoa
    {
        void SetNome(string nome);
        void SetTelefone(string telefone);
        void SetCpf(string cpf);

        void Gravar();
    }
}
