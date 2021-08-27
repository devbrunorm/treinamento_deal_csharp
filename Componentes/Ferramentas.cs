using System;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembler() 
        {
            return "Este método s[o pode ser acessado dentro deste assembly componentes";
        }

        public string MetodoParaTodosQueUtilizarOAssembly()
        {
            return "Este método s[o pode ser acessado dentro deste assembly componentes";
        }

        public bool ValidarCPF(string cpf)
        {
            return true;
        }
    }
}
