using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    class ItemNotaFiscal
    {
        public int Qtde { get; set; }

        public ItemNotaFiscal(int qtde)
        {
            Qtde = qtde;
        }
        ~ItemNotaFiscal()
        {
            Console.WriteLine("Destrutor Item Nota Fiscal");
        }
    }
}
