using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoArrayBibliotecaAluno
{
    class Aluno
    {
        private int matricula;
        private string nome;
        public int Matricula
        {
            set { this.matricula = value; }
            get { return this.matricula; }
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
    }
}
