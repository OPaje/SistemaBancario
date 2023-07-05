using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Conta : BaseEntity
    {
        private int agencia;
        private int numeroConta;
        private String nomeConta;
        private Titular titular;
        private Decimal saldo;

        public int Agencia { get => agencia; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
        public String NomeConta { get => nomeConta; set => nomeConta = value; }
        public Titular Titular { get => titular ; set => titular = value; }
        public Decimal Saldo { get => saldo; set => saldo = value; }

        public override bool Equals(object obj)
        {
            return obj is Conta conta &&
                   Id.Equals(conta.Id);
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"ID : {Id} Agência: {Agencia} Número Conta: {NumeroConta} \nTitular: {Titular}";
        }
    }

}
