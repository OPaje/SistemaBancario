using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public String NomeConta { get; set;}
        public Titular Titular { get; set; }
        public Decimal Saldo { get; set; }

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
