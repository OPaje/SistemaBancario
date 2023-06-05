using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.model
{
    class ContaDAO
    {
        public List<Conta> AdicionaConta(Conta conta)
        {
            List<Conta> contas = new List<Conta>();
            contas.Add(conta);

            return contas;
        }
    }
}
