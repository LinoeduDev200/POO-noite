using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoBibliotecaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.Matricula = 1;
            a1.Nome = "Bia";

            Biblioteca b1 = new Biblioteca();
            b1.Codigo = 15;
            b1.Nome = "Biblioteca da Fatec";
            b1.Aluno_ = a1;
            Console.WriteLine("Nome: " +
                b1.Aluno_.Nome);
            

            Biblioteca b2 = new Biblioteca();
            b2.Codigo = 16;
            b2.Nome = "Biblioteca de estado";
            b2.Aluno_ = new Aluno();
            b2.Aluno_.Matricula = 2;
            b2.Aluno_.Nome = "Léo";
            Console.WriteLine("Nome: " +
                b2.Aluno_.Nome);
            Console.ReadKey();
        }
    }
}
