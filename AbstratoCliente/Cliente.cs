using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    abstract class Cliente
    {
        protected int codigo;
        protected string nome;
        protected int idade;
        public abstract bool VerificaIdade();
        public virtual void Mostrar()//polimorfismo
        {
            Console.WriteLine("Código: " + Codigo +
                "\tNome: " + Nome + "\tIdade: " + Idade);
        }
        public int Idade
        {
            set { this.idade = value; }
            get { return this.idade; }
        }
        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public int Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }
    }
}
