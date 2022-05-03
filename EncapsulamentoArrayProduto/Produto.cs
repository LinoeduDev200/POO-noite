using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoArrayProduto
{
    class Produto
    {
        //declaração dos atributos encapsulados
        private int codigo;
        private string nome;
        private double preco;
        //declaração dos métodos de encapsulamento
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
        public double Preco
        {
            get
            {
                return this.preco;
            }
            set
            {
                this.preco = value;
            }
        }
    }
}
