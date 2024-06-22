using RegistroPonto.WinApp.ModuloAluno;
using RegistroPonto.WinApp.ModuloAula;

namespace RegistroPonto.WinApp.ModuloChamada
{
    public class Participacao
    {
        public Participacao(Aula aula, Aluno aluno)
        {
            Aula = aula;
            Aluno = aluno;
        }

        public Aula Aula { get; set; }

        public Aluno Aluno { get; set; }
    }
}
