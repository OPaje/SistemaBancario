using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Titular
    {
        private String nome;
        private String cpf;
        private String rg;
        private String endereco;

        public String Nome { get => nome; set => nome = value; }
        public String Cpf { get => cpf; set => cpf = value; }
        public String Rg { get => rg; set => rg = value; }
        public String Endereco { get => endereco; set => endereco = value; }

        public override string ToString()
        {
            return  "\n\tNome: " + Nome.ToString() + "\n\tCPF: " + Cpf.ToString();
        }
    }
}
