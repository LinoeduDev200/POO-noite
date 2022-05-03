using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoArrayContaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            cli1.Nome = "Ana";
            cli1.Rg = "11";
            cli1.Cpf = "111";
            Cliente cli2 = new Cliente();
            cli2.Nome = "Bia";
            cli2.Rg = "22";
            cli2.Cpf = "222";
            Conta c = new Conta();
            c.Numero = 1;
            c.Saldo = 100;
            List<Cliente> vet = new List<Cliente>();   
            vet.Add(cli1);
            vet.Add(cli2);
            foreach (Cliente cl in vet)
            {
                Console.WriteLine("Nome: " + cl.Nome);
            }
            Console.ReadKey();

        }
    }
}
