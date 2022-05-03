using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoArrayProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] vetP = new Produto[3];
            for (int i = 0; i < vetP.Length; i++)
            {            
                    //manipulação do vetor de OBJETOS
                    //instância de cada índice do vetor
                    vetP[i] = new Produto();
                    Console.Write("Informe o código: ");
                    vetP[i].Codigo = Convert.ToInt32(
                        Console.ReadLine());
                    Console.Write("Informe o nome: ");
                    vetP[i].Nome = Console.ReadLine();
                    Console.Write("Informe o Preço: ");
                    vetP[i].Preco = Convert.ToDouble(
                        Console.ReadLine());
            }
            double total = 0;
            foreach(Produto p in vetP)
            {
                total = total + p.Preco;
            }
            Console.WriteLine("Total de preços R$ "+ total);
            Console.ReadKey();
        }
    }
}
