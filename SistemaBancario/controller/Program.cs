using SistemaBancario.model;
using SistemaBancario.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Program
    {
        ContaDAO contaDAO = new ContaDAO();
        GUI gui = new GUI();
        public Program()
        {
            
            int opcao = 0;
            do
            {
                opcao = gui.Menu();
                switch (opcao)
                {
                    case 1:
                        Conta conta = gui.criarConta();
                        contaDAO.AdicionaConta(conta);
                        Console.WriteLine("Cadastrado com Sucesso. \nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        contaDAO.mostrarContas();
                        //long id = gui.perguntarId();
                        if (contaDAO.sacar(contaDAO.buscarConta(gui.perguntarId()), gui.perguntarValor()))
                        {
                            Console.WriteLine("Saque efetuado com Sucesso. \nPressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();

                        }else
                        {
                            Console.WriteLine("Não foi possível efetuar o saque");
                        }
                        
                        
                        break;

                    case 3:
                        contaDAO.mostrarContas();
                        contaDAO.depositar(contaDAO.buscarConta(gui.perguntarId()), gui.perguntarValor());
                        Console.WriteLine("Deposito efetuado com Sucesso. \nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        contaDAO.mostrarContas();
                        Decimal saldo = contaDAO.verSaldo(contaDAO.buscarConta(gui.perguntarId()));
                        Console.WriteLine($"Saldo da conta: {saldo}");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcao > 0 && opcao < 6);
        }

        static void Main(string[] args)
        {
            new Program();
            /*

            Console.WriteLine("Id conta: " + conta.Id);

            Console.WriteLine($"Titular: {conta.Titular}");

            Console.WriteLine($"Saldo atual: {conta.verSaldo()}");

            conta.depositar(500);

            Console.WriteLine($"Saldo depois do deposito: {conta.verSaldo()}");

            conta.sacar(500);

            Console.WriteLine($"Saldo depois do saque: {conta.verSaldo()}");

            conta.sacar(1550);*/

            Console.ReadKey();
        }
    }
}
