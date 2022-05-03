using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduto
{
    class Produto
    {
        //declaração de atributos
        public int codigo;
        public string nome;
        public double preco;

        //declaração de métodos-funções
        public void Mostrar()
        {
            Console.WriteLine("Código: " + codigo +
                    "\tNome: " + nome +
                    "\tPreço: " + preco);
        }
        public void CalcularAumento(double percent)
        {
            preco = preco + preco * percent / 100;
        }

    }
}
