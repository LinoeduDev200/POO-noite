using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoPagamento
{
    class Pagamento
    {
        private string data;
        private double valor;
        private int tipo;
        private int parcela;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public double Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }
        public int Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        public int Parcela
        {
            get { return this.parcela; }
            set { this.parcela = value; }
        }
    }
}
