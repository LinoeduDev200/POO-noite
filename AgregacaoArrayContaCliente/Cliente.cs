using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoArrayContaCliente
{
    class Cliente
    {
        private string nome;
        private string rg;
        private string cpf;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public string Rg
        {
            get { return this.rg; }
            set { this.rg = value; }
        }
        public string Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }
    }
}
