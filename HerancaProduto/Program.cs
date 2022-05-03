using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Produto p = new Produto();
            p.Codigo = 1;
            p.Nome = "mouse";
            p.Preco = 100;
            p.Mostrar();

            Perecivel pe = new Perecivel();
            pe.Codigo = 2;
            pe.Nome = "Mussarela";
            pe.Preco = 21;
            pe.DataFabricacao = "09/04/2022";
            pe.DataValidade = "12/04/2022";
            pe.Mostrar();*/

            Produto p1 = new Produto(3, "teclado", 200);
            p1.Mostrar();

            Perecivel pe2 = new Perecivel(4, "mortadela", 7,
                "09/04/2002", "13/04/2022");
            pe2.Mostrar();
            Console.ReadKey();
        }
    }
}
