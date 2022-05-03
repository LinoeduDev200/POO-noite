using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoBibliotecaAluno
{
    class Biblioteca
    {
        private int codigo;
        private string nome;
        private Aluno aluno_;

        public int Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public Aluno Aluno_
        {
            get { return this.aluno_; }
            set { this.aluno_ = value; }
        }
    }
}
