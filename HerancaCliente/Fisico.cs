using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class Fisico : Cliente // : indica a heranca
    {
        private string rg;
        private string cpf;

        public string Rg
        {
            set { this.rg = value; }
            get { return this.rg; }
        }
        public string Cpf
        {
            set { this.cpf = value; }
            get { return this.cpf; }
        }
        public void Mostrar()
        {
            //this.
        }
    }
}
