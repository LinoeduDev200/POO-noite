using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVendaProduto
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

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
                    "\tPreço: " + Preco);
        }
    }
}
