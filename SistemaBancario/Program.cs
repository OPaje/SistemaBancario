using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.NomeConta = "Conta Conta";
            conta.NumeroConta = 1010;
            conta.Saldo = 1000;
            conta.Agencia = 14;

            conta.Titular = new Titular()
            {
                Nome = "Jean",
                Cpf = "1232434",
                Rg = "MG-098322",
                Endereco = "Brasil"

            };

            Console.WriteLine($"Titular: {conta.Titular}");

            Console.WriteLine($"Saldo atual: {conta.verSaldo()}");

            conta.depositar(500);

            Console.WriteLine($"Saldo depois do deposito: {conta.verSaldo()}");

            conta.sacar(500);

            Console.WriteLine($"Saldo depois do saque: {conta.verSaldo()}");

            conta.sacar(1550);

            Console.ReadKey();
        }
    }
}
