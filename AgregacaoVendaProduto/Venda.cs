using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVendaProduto
{
    class Venda
    {
        public int Codigo { get; set; }
        public string Data { get; set; }
        public double Total { get; set; }
        private List<Produto> vetP;

        public List<Produto> VetP
        {
            get { return this.vetP; }
            set
            {
                this.vetP = new List<Produto>();
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo +
                    "\tData: " + Data +
                    "\tTotal: " + Total);
        }
    }
}
