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
            var titular = new Titular();

            Console.WriteLine("Informe o nome do titular: ");
            titular.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do titular: ");
            titular.Cpf = Console.ReadLine();

            Console.WriteLine("Informe o RG do titular: ");
            titular.Rg = Console.ReadLine();

            Console.WriteLine("Informe o endereço do titular: ");
            titular.Endereco = Console.ReadLine();

            conta.Titular = titular;

            Console.WriteLine("Informe o nome da conta: ");
            conta.NomeConta = Console.ReadLine();

            Console.WriteLine("Informe o número da conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());

            conta.Saldo = 500; // ganha R$500 quanto abre a conta

            Console.WriteLine("Informe a agência: ");
            conta.Agencia = int.Parse(Console.ReadLine());

            

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
