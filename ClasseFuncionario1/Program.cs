using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();//instância de objeto
            f1.matricula = 1;
            f1.nome = "Ana";
            f1.salario = 1000;
            f1.Mostrar();
            f1.CalcularAumento(5);
            f1.Mostrar();
            Console.ReadKey();
        }
    }
}
