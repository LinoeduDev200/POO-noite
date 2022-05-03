using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoArrayContaCliente
{
    class Conta
    {
        private int numero;
        private List<Cliente> titular;
            
        private double saldo;
        public int Numero
        {
            set { this.numero = value; }
            get { return this.numero; }
        }
        public List<Cliente> Titular
        {
            set { this.titular = new List<Cliente>(); }
            get { return this.titular; }
        }
        public double Saldo
        {
            set { this.saldo = value; }
            get { return this.saldo; }
        }
    }
}
