using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoConta1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            //este objeto esta usando o método set
            c1.Numero = 12;
            c1.Titular = "Fulano";
            c1.Saldo = 100;
            //este objeto esta usando o método get
            Console.WriteLine("Número: "+ c1.Numero);
            Console.WriteLine("Titular: "+ c1.Titular);
            Console.WriteLine("Saldo: " + c1.Saldo);

            Console.ReadKey();
        }
    }
}
