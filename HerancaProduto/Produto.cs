using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProduto
{
    class Produto
    {
        protected int codigo;
        protected string nome;
        protected double preco;

        //Produto() { }
        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo +
                "\tNome: " + Nome + 
                "\tPreço: "+Preco);
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
        public double Preco
        {
            set { this.preco = value; }
            get { return this.preco; }
        }
    }
}
