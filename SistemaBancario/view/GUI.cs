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
            builder.Append("\n5 - Sair");
            builder.Append("\nInforme sua opção");

            Console.WriteLine(builder);
            return int.Parse(Console.ReadLine());
        }
    }
}
