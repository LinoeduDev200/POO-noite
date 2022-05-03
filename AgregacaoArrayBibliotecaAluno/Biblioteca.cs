using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoArrayBibliotecaAluno
{
    class Biblioteca
    {
        private int codigo;
        private string nome;
        private List<Aluno> aluno_;//passar para vetor

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
        public List<Aluno> Aluno_
        {
            get { return this.aluno_; }
            set { this.aluno_ = value; }
        }
    }
}
