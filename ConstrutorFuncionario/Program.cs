using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Lia");//instância de objeto
            f1.Mostrar();
            Funcionario f2 = new Funcionario("Ana",1000);
            f2.Mostrar();
            f2.CalcularAumento(5);
            f2.Mostrar();
            Console.ReadKey();
        }
    }
}
