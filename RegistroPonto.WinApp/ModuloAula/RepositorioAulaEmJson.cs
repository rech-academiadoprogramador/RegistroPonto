using RegistroPonto.WinApp.Compartilhado;

namespace RegistroPonto.WinApp.ModuloAula
{
    public class RepositorioAulaEmJson : RepositorioBase<Aula>, IRepositorioAula
    {
        public RepositorioAulaEmJson(List<Aula> aulas) : base(aulas)
        {
        }        
    }
}
