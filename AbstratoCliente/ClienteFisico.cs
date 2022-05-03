using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class ClienteFisico : Cliente
    {
        private int rg;
        public int Rg
        {
            get { return this.rg; }
            set { this.rg = value; }
        }
        public ClienteFisico(int codigo, string nome, int idade,
            int rg) : base(codigo, nome, idade)
        {
            Rg = rg;
        }

        public override bool VerificaIdade()
        {
            if (Idade < 50)
                return true;
            return false;
        }
        public override void Mostrar()
        {
            base.Mostrar();//chamada do método da classe base
            Console.WriteLine("Rg: " + Rg);
        }
    }
}
