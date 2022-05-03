using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declarar os atributos da classe funcionário
            os métodos, e na main(), manipular o vetor
            * Crie um método de apresentação dos atributos
            * Crie um método para calcular aumento(porcentagem)
            * na main, deve ser apresentado o total de salários
            * pagos de todos os funionários e também, mostrar 
            * o que ganha mais.  */
            //declaração do vetor
            Funcionario[] vetF = new Funcionario[3];
            double total = 0, ganhaMais = 0, ganhaMenos = 0;
            string nomeMais = "", nomeMenos = "";
            for (int i = 0; i < vetF.Length; i++)
            {                
                //instânciar cada posição/índice do vetor
                vetF[i] = new Funcionario();
                Console.Write("Informe a matrícula: ");
                vetF[i].matricula = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o nome: ");
                vetF[i].nome = Console.ReadLine();
                Console.Write("Informe o salário: ");
                vetF[i].salario = Convert.ToDouble(Console.ReadLine());
                
                if (i == 0)
                {
                    ganhaMais = vetF[i].salario;
                    nomeMais = vetF[i].nome;
                    ganhaMenos = vetF[i].salario;
                    nomeMenos = vetF[i].nome;
                }
                if (vetF[i].salario >= ganhaMais)
                {
                    ganhaMais = vetF[i].salario;
                    nomeMais = vetF[i].nome;
                }
                if (vetF[i].salario <= ganhaMenos)
                {
                    ganhaMenos = vetF[i].salario;
                    nomeMenos = vetF[i].nome;
                }
            }
            
            Console.WriteLine("O maior salário encontrado foi " + ganhaMais +
                " do funcionário " + nomeMais);
            Console.WriteLine("O menor salário encontrado foi " + ganhaMenos +
                " do funcionário " + nomeMenos);

            Console.Write("\nInforme a porcentagem de aumento: ");
            double porce = Convert.ToDouble(Console.ReadLine());

            foreach (Funcionario f in vetF)
            {
                f.CalcularAumento(porce);
                total = total + f.salario;
                f.Mostrar();
            }
            Console.WriteLine("O total de salários pagos é " + total);
            Console.ReadKey();
        }
    }
}
