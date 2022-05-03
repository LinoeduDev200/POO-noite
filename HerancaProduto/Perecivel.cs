using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProduto
{
    class Perecivel : Produto
    {
        private string dataFabricacao;
        private string dataValidade;
        //Perecivel(): base() { }
        public Perecivel(int codigo, string nome, double preco,
            string dataFabricacao, string dataValidade)
            : base(codigo,nome,preco)
        {
            DataFabricacao = dataFabricacao;
            DataValidade = dataValidade;
        }

        public void Mostrar()
        {
            //base chama o método da SUPERCLASSE
            base.Mostrar();
            Console.WriteLine("Data de fabricação: " +
                DataFabricacao + "\tData de validade: " +
                DataValidade);
        }
        public string DataFabricacao
        {
            set { this.dataFabricacao = value; }
            get { return this.dataFabricacao; }
        }
        public string DataValidade
        {
            set { this.dataValidade = value; }
            get { return this.dataValidade; }
        }
    }
}
