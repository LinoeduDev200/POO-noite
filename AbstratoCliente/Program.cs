using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            //instância de objeto da classe base/superclasse
            //Cliente c = new Cliente(1, "Ana");

            //instância de objeto da classe derivada
            ClienteFisico cf = new ClienteFisico(2, "Bia",35, 1111);
            cf.Mostrar();

            Teste t = new Teste();
            Console.WriteLine( t.AnalisarIdadeClientes(cf) );

            Console.ReadKey();

        }
    }
}
