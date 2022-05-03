using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    class Gerente : Funcionario
    {
        public Gerente(int codigo, string nome, double salario)
            : base(codigo, nome, salario)
        {

        }
        public override double CalcularBonificacao()
        {
            return Salario * 15 / 100;
        }
    }
}
