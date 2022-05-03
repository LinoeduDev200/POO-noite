using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    class Funcionario
    {
        //declaração dos atributos com encapsulamento
        private int matricula;
        private string nome;
        private double salario;

        //declaração dos métodos de encapsulamento
        public int Matricula
        {
            set
            {
                this.matricula = value;
            }
            get
            {
                return this.matricula;
            }
        }
        public string Nome
        {
            set
            {
                this.nome = value;
            }
            get
            {
                return this.nome;
            }
        }
        public double Salario
        {
            set
            {
                this.salario = value;
            }
            get
            {
                return this.salario;
            }
        }

    }
}
