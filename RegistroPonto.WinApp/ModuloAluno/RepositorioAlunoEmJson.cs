using RegistroPonto.WinApp.Compartilhado;
using System.Text.Json;

namespace RegistroPonto.WinApp.ModuloAluno
{
    public class RepositorioAlunoEmJson : RepositorioBase<Aluno>, IRepositorioAluno
    {
        public RepositorioAlunoEmJson(List<Aluno> alunos) : base(alunos)
        {
        }                             


    }
}
