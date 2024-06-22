using RegistroPonto.WinApp.ModuloAluno;
using RegistroPonto.WinApp.ModuloAula;

namespace RegistroPonto.WinApp.ModuloChamada
{
    public class Ausencia : Participacao
    {
        public Ausencia(Aula aula, Aluno aluno) : base(aula, aluno)
        {
        }
    }
}
