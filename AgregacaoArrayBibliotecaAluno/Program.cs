using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoArrayBibliotecaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.Nome = "Ana";
            a1.Matricula = 10;
            Aluno a2 = new Aluno();
            a2.Nome = "Bia";
            a2.Matricula = 11;
            Biblioteca c = new Biblioteca();
            c.Codigo = 1;
            c.Nome = "Biblioteca da Fatec";
            List<Aluno> vetA = new List<Aluno>();
            vetA.Add(a1);
            vetA.Add(a2);
            foreach (Aluno a in vetA)
            {
                Console.WriteLine("Nome: " + 
                    a.Nome);
            }
            Console.ReadKey();
        }
    }
}
