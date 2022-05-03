using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaCliente
{
    class Conta
    {
        private int numero;
        private Cliente titular;
        private double saldo;
        public int Numero
        {
            set { this.numero = value; }
            get { return this.numero; }
        }
        public Cliente Titular
        {
            set { this.titular = value; }
            get { return this.titular; }
        }
        public double Saldo
        {
            set { this.saldo = value; }
            get { return this.saldo; }
        }
    }
}
