using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConta
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variável
            Conta conta1;
            //instanciação de objeto
            conta1 = new Conta();//Conta() - construtor
            conta1.numero = 101;
            conta1.titular = "Giovana";
            conta1.saldo = 1000;
            conta1.MostrarAtributos();

            //declaração e instanciação
            Conta conta2 = new Conta();
            Console.Write("Digite o número da conta: ");
            conta2.numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            conta2.titular = Console.ReadLine();
            Console.Write("Digite o saldo da conta: ");
            conta2.saldo = Convert.ToDouble(Console.ReadLine());
            conta2.MostrarAtributos();
            conta2.Transferir(100, conta1);
            conta1.MostrarAtributos();
            conta2.MostrarAtributos();
            /*
            Conta conta3 = new Conta();//instanciação de objeto
            Console.WriteLine("Digite o valor a sacar: ");
            double saque = Convert.ToDouble(Console.ReadLine());
            conta3.Depositar(1000);
            conta3.Sacar(saque);
            conta3.MostrarAtributos();*/
            Console.ReadKey();
        }
    }
}
