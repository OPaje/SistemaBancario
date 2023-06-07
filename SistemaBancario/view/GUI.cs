using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.view
{
    class GUI
    {
        public int Menu()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("1 - Cadastrar");
            builder.Append("\n2 - Sacar");
            builder.Append("\n3 - Depositar");
            builder.Append("\n4 - Ver Saldo");
            builder.Append("\n5 - Trasnferir");
            builder.Append("\n6 - Sair");
            builder.Append("\nInforme sua opção");

            Console.WriteLine(builder);
            return int.Parse(Console.ReadLine());
        }

        public Conta criarConta()
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

            Console.WriteLine("Informe o Id da conta: ");
            conta.Id = long.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da conta: ");
            conta.NomeConta = Console.ReadLine();

            Console.WriteLine("Informe o número da conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());

            conta.Saldo = 500; // ganha R$500 quanto abre a conta

            Console.WriteLine("Informe a agência: ");
            conta.Agencia = int.Parse(Console.ReadLine());

            return conta;
        }

        public long perguntarId()
        {
            Console.WriteLine("Informe o Id da conta: ");
            return long.Parse(Console.ReadLine());
        }

        public Decimal perguntarValor()
        {
            Console.WriteLine("Informe o valor: ");
            return Decimal.Parse(Console.ReadLine());
        }
    }
}
