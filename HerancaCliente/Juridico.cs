using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class Juridico : Cliente
    {
        private int cnpj;
        private int ie; //inscrição estadual
        private int im; //inscrição municipal
        public int Cnpj
        {
            set { this.cnpj = value; }
            get { return this.cnpj; }
        }
        public int Ie
        {
            set { this.ie = value; }
            get { return this.ie; }
        }
        public int Im
        {
            set { this.im = value; }
            get { return this.im; }
        }
    }
}
