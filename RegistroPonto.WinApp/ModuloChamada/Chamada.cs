using RegistroPonto.WinApp.Compartilhado;
using RegistroPonto.WinApp.ModuloAluno;
using RegistroPonto.WinApp.ModuloAula;
using RegistroPonto.WinApp.ModuloTurma;

namespace RegistroPonto.WinApp.ModuloChamada
{
    public class Chamada : EntidadeBase
    {
        public Chamada(Aula aula, Turma turma)
        {
            Aula = aula;
            Turma = turma;

            Participacoes = new List<Participacao>();
        }

        public Aula Aula { get; set; }
        public Turma Turma { get; set; }
        public List<Participacao> Participacoes { get; private set; }
        
        public void RegistrarAusencia(Aluno aluno)
        {
            var ausencia = new Ausencia(Aula, aluno);

            Participacoes.Add(ausencia);

            aluno.RegistrarAusencia(ausencia);
        }

        public void RegistrarPresenca(Aluno aluno)
        {
            var presenca = new Presenca(Aula, aluno);

            Participacoes.Add(presenca);

            aluno.RegistrarPresenca(presenca);
        }
    }
}
