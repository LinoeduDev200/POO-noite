using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    class Funcionario
    {
        //declaração de atributos
        public int matricula;
        public string nome;
        public double salario;

        //declaração de métodos
        public void Mostrar()
        {
            Console.WriteLine("Matrícula: " + matricula +
                    "\tNome: " + nome +
                    "\tSalário: " + salario);        
        }
        public void CalcularAumento(double percent)
        {
            salario = salario + salario * percent / 100;
        }
    }
}
