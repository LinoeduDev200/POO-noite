using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            c1.Mostrar();
            Conta c2 = new Conta(1);
            c2.Mostrar();
            Conta c3 = new Conta(2,"Ana",100);
            c3.Mostrar();
            Console.WriteLine("\nQuantidade de intâncias? "+ Conta.Contador);
            Console.ReadKey();
        }
    }
}
