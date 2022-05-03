using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario(1, "Luana", 1000);
            Console.WriteLine("Bonificação: "+
                f.CalcularBonificacao() );

            Secretario s = new Secretario(2, "Liz", 1000);
            Console.WriteLine("Bonificação: " +
                s.CalcularBonificacao());

            Gerente g = new Gerente(3, "Beatriz", 1000);
            Console.WriteLine("Bonificação: " +
                g.CalcularBonificacao());

            Diretor d = new Diretor(4, "Ana", 1000);
            Console.WriteLine("Bonificação: " +
                d.CalcularBonificacao());

            Console.ReadKey();
        }
    }
}
