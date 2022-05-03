using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    class Diretor : Funcionario
    {
        public Diretor(int codigo, string nome, double salario)
            : base(codigo, nome, salario)
        {

        }
        public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao() + 1000;
        }
    }
}
