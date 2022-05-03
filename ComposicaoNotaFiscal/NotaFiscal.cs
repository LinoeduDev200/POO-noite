using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    class NotaFiscal
    {
        public int Numero { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> Item { get; set; }

        public NotaFiscal(int numero, string data, 
            List<ItemNotaFiscal> item)
        {
            Numero = numero;
            Data = data;
            Item = item;
        }
        ~NotaFiscal(){
            Item = null;
            Console.WriteLine("Destrutor da Nota Fiscal");
        }
    }
}
