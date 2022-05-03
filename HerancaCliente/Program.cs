using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.Codigo = 1;
            c.Nome = "Lia";
            Fisico f = new Fisico();
            f.Codigo = 2;
            f.Nome = "Bia";
            f.Rg = "22";
            f.Cpf = "2222";
            Juridico j = new Juridico();
            j.Codigo = 3;
            j.Nome = "Empresa S/A";
            j.Cnpj = 33;
            j.Ie = 3333;
            j.Im = 33333;
        }
    }
}
