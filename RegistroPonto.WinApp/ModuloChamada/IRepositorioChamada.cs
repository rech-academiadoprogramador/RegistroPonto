using RegistroPonto.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.WinApp.ModuloChamada
{
    public interface IRepositorioChamada
    {
        void Adicionar(Chamada chamada);

        void Editar(Chamada chamada);

        void Excluir(Chamada chamada);

        List<Chamada> SelecionarTodos();
    }
}
