using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Conta
    {
        private int agencia;
        private int numeroConta;
        private String nomeConta;
        private Titular titular;
        private Decimal saldo;

        public int Agencia { get => agencia; set => agencia = value; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
        public String NomeConta { get => nomeConta; set => nomeConta = value; }
        public Titular Titular { get => titular ; set => titular = value; }
        public Decimal Saldo { get => saldo; set => saldo = value; }

        public Decimal verSaldo()
        {
            return Saldo;
        }

        public void depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void sacar(decimal valor)
        {
            if(valor < Saldo){
                Saldo -= valor;
            }
            else{
                Console.WriteLine("Não foi possível fazer o saque. Saldo insuficiente");
            }
            
        }
       
    }

}
