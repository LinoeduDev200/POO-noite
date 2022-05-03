using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento p = new Pagamento();
            //método set, quando tem sinal de atribuição
            p.Data = "19/03/2022";
            p.Valor = 1000;
            p.Tipo = 1;
            p.Parcela = 3;
            //médoto get
            Console.WriteLine("Data: " + p.Data);
        }
    }
}
