using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();
            cli.Nome = "Lia";
            cli.Rg = "111";
            cli.Cpf = "1111";

            Conta c1 = new Conta();
            c1.Numero = 1;
            c1.Titular = cli;
            c1.Saldo = 100;
            Console.WriteLine("Nome: "
                + c1.Titular.Nome);

            // outra forma de demonstrar agregação
            Conta c2 = new Conta();
            c2.Numero = 2;
            c2.Titular = new Cliente();
            c2.Titular.Nome = "Ana";
            c2.Titular.Rg = "222";
            c2.Titular.Cpf = "2222";
            Console.WriteLine("Nome: "
                + c2.Titular.Nome);

            Console.ReadKey();
        }
    }
}
