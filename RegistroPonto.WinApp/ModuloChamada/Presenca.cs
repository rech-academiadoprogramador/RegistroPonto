using RegistroPonto.WinApp.ModuloAluno;
using RegistroPonto.WinApp.ModuloAula;

namespace RegistroPonto.WinApp.ModuloChamada
{
    public class Presenca : Participacao
    {
        public Presenca(Aula aula, Aluno aluno) : base(aula, aluno)
        {
        }
    }
}
