using RegistroPonto.WinApp.Compartilhado;

namespace RegistroPonto.WinApp.ModuloAula
{
    public interface IRepositorioAula
    {
        void Adicionar(Aula aula);

        void Editar(Aula aula);

        void Excluir(Aula aula);

        List<Aula> SelecionarTodos();
    }
}
