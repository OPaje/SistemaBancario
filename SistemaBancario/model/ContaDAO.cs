using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.model
{
    class ContaDAO
    {
        List<Conta> contas = new List<Conta>();
        public ContaDAO()
        {
            Conta conta = new Conta();
            Titular titular = new Titular();

            titular.Nome = "Jean";
            titular.Id = 1;
            titular.Rg = "344314";
            titular.Cpf = "434341341";
            titular.Endereco = "Uberaba";

            conta.Id = 1;
            conta.NomeConta = "Minha conta";
            conta.NumeroConta = 14;
            conta.Agencia = 1;
            conta.Saldo = 500;
            conta.Titular = titular;

            contas.Add(conta);
        }

        public List<Conta> AdicionaConta(Conta conta)
        {
            
            contas.Add(conta);

            return contas;
        }

        public void mostrarContas()
        {
            foreach(Conta conta in contas){
                Console.WriteLine(conta.ToString());
            }
        }

        public Decimal verSaldo(Conta conta)
        {
            return conta.Saldo;
        }

        public void depositar(Conta conta, decimal valor)
        {
            conta.Saldo += valor;
        }

        public Boolean sacar(Conta conta, decimal valor)
        {
            if (valor < conta.Saldo)
            {
                conta.Saldo -= valor;

                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean transferir(Conta contaDestino, Conta contaOrigem, Decimal valor)
        {
            if(sacar(contaOrigem, valor))
            {
                contaDestino.Saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Conta buscarConta(long id)
        {
            Conta conta = new Conta();
             for(int i=0; i<contas.Count; i++)
            {
                if(contas[i].Id == id)
                {
                    conta = contas[i];
                }
            }

            return conta;
        }
    }
}
