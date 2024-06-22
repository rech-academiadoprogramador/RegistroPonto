using RegistroPonto.WinApp.Compartilhado;
using RegistroPonto.WinApp.ModuloAluno;
using RegistroPonto.WinApp.ModuloAula;

namespace RegistroPonto.WinApp.ModuloTurma
{
    public class Turma : EntidadeBase
    {
        public Turma(int id, string periodo, int ano)
        {
            Id = id;
            Periodo = periodo;
            Ano = ano;
            Alunos = new List<Aluno>();
            Aulas = new List<Aula>();
        }

        public string Periodo { get; set; }
        public int Ano { get; set; }

        public List<Aluno> Alunos { get; set; }

        public List<Aula> Aulas { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, {Periodo}, {Ano}";
        }
    }
}
