using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            //método set
            f.Matricula = 1;
            f.Nome = "Fulano";
            f.Salario = 1000;
            //método get
            Console.WriteLine("matrícula: " + f.Matricula);
            Console.WriteLine("Nome: "+f.Nome);
            Console.WriteLine("Salário: "+f.Salario);
            Console.ReadKey();
        }
    }
}
