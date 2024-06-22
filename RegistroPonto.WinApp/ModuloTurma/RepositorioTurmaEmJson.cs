using RegistroPonto.WinApp.Compartilhado;
using RegistroPonto.WinApp.ModuloAluno;
using RegistroPonto.WinApp.ModuloAula;

namespace RegistroPonto.WinApp.ModuloTurma
{
    public class RepositorioTurmaEmJson : RepositorioBase<Turma>, IRepositorioTurma
    {
        public RepositorioTurmaEmJson(List<Turma> turmas) : base(turmas)
        {
        }        
    }


}
