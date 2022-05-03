using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    class Funcionario
    {
        //declaração de atributos
        private static int matricula;
        private string nome;
        private double salario;
        private static int contador;

        //declaração de métodos CONSTRUTORES
        static Funcionario()//o construtor static é SEMPRE executado primeiro
        {// depois executa os outros construtores
            matricula = 100;
        }
        public Funcionario(string nome)
        {
            matricula = matricula + 1;
            this.nome = nome;
            contador = contador + 1; //incremento
        }
        public Funcionario(string nome, double salario)
        {
            matricula = matricula + 1;
            this.nome = nome;
            this.salario = salario;
            contador = contador + 1; //incremento
        }

        //declaração de método de encapsulamento
        public static int Contador
        {
            get { return contador; }
        }

        //declaração de métodos
        public void Mostrar()
        {
            Console.WriteLine("Matrícula: " + matricula +
                    "\tNome: " + nome + "\tSalário: " + salario);
        }

        public void CalcularAumento(double percent)
        {
            salario = salario + salario * percent / 100;
        }
    }
}
