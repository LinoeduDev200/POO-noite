using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoBancoContaCorrente
{
    class Banco
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<ContaCorrente> VetC { get; set; }

        public Banco(int codigo, string nome, List<ContaCorrente> vetC)
        {
            Codigo = codigo;
            Nome = nome;
            VetC = vetC;
        }
        ~Banco()
        {
            VetC = null;
            Console.WriteLine("Destrutor do Banco");
        }
    }
}
