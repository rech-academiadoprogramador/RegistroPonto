
using RegistroPonto.WinApp.Compartilhado;

namespace RegistroPonto.WinApp.ModuloChamada
{
    public class RepositorioChamadaEmJson : RepositorioBase<Chamada>, IRepositorioChamada
    {
        public RepositorioChamadaEmJson(List<Chamada> chamadas) : base(chamadas)
        {            
        }               
    }
}
