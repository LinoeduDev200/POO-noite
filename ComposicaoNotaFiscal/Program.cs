using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemNotaFiscal i1 = new ItemNotaFiscal(12);
            ItemNotaFiscal i2 = new ItemNotaFiscal(25);
            List<ItemNotaFiscal> vetItem =
                new List<ItemNotaFiscal>();
            vetItem.Add(i1);
            vetItem.Add(i2);
            NotaFiscal nf = new NotaFiscal(1, "02/04/2022",
                vetItem);
            foreach (ItemNotaFiscal i in nf.Item)
            {
                Console.WriteLine("Itens:" + i.Qtde);
            }
            //retirar a referência do objeto
            nf = null;
            //forçar a chamada do coletor de lixo
            GC.Collect();
            Console.ReadKey();
        }
    }
}
