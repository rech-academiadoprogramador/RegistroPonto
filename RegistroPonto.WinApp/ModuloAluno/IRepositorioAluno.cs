using RegistroPonto.WinApp.Compartilhado;

namespace RegistroPonto.WinApp.ModuloAluno
{
    public interface IRepositorioAluno
    {
        void Adicionar(Aluno aluno);
        void Editar(Aluno aluno);
        void Excluir(Aluno aluno);
        List<Aluno> SelecionarTodos();
    }
}
