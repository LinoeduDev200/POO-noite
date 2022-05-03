using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            //instância de objeto individual
            Produto p = new Produto();
            p.codigo = 1;
            p.nome = "lanche";
            p.preco = 20;
            p.Mostrar();
            p.CalcularAumento(5);
            p.Mostrar();
            //declaração de vetor de objetos
            Produto[] vetP = new Produto[3];
            for (int i = 0; i < vetP.Length; i++)
            {
                //manipulação do vetor de OBJETOS
                //instância de cada índice do vetor
                vetP[i] = new Produto();
                Console.Write("Informe o código: ");
                vetP[i].codigo = Convert.ToInt32(
                    Console.ReadLine());
                Console.Write("Informe o nome: ");
                vetP[i].nome = Console.ReadLine();
                Console.Write("Informe o Preço: ");
                vetP[i].preco = Convert.ToDouble(
                    Console.ReadLine());
            }
            Console.Write("Informe a porcentagem: ");
            double porcentagem = Convert.ToDouble(
                Console.ReadLine());
            foreach (Produto vp in vetP)
            {
                vp.Mostrar();
                vp.CalcularAumento(porcentagem);
            }
            Console.WriteLine();
            foreach (Produto vp in vetP)
                vp.Mostrar();            
            Console.ReadKey();
        }
    }
}
