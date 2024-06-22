using RegistroPonto.WinApp.Compartilhado;

namespace RegistroPonto.WinApp.ModuloTurma
{
    public interface IRepositorioTurma
    {
        void Adicionar(Turma turma);

        void Editar(Turma turma);

        void Excluir(Turma turma);

        List<Turma> SelecionarTodos();
    }
}
