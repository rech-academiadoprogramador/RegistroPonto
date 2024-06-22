
namespace RegistroPonto.WinApp.Compartilhado
{
    public class RepositorioBase<T> where T : EntidadeBase
    {
        protected List<T> registros;

        public RepositorioBase(List<T> registros)
        {
            this.registros = registros;
        }

        public void Adicionar(T registro)
        {
            registros.Add(registro);
        }

        public void Editar(T registroAtualizado)
        {
            T registro = registros.Find(r => r.Id == registroAtualizado.Id)!;

            if (registro == null)
                return;

            registro.AtualizarDados(registroAtualizado);            
        }

        public void Excluir(T registroParaRemover)
        {
            registros.Remove(registroParaRemover);
        }

        public List<T> SelecionarTodos()
        {
            return registros.Cast<T>().ToList();
        }
    }
}
