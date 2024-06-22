using RegistroPonto.WinApp.Compartilhado;
using RegistroPonto.WinApp.ModuloTurma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.WinApp.ModuloChamada
{
    public class ControladorChamada : IControlador
    {
        ListaChamadasControl listaChamadasControl;

        private IRepositorioChamada repositorioChamada;
        private IRepositorioTurma repositorioTurma;

        public ControladorChamada(IRepositorioChamada repositorioChamada, IRepositorioTurma repositorioTurma)
        {
            this.repositorioChamada = repositorioChamada;
            this.repositorioTurma = repositorioTurma;
        }

        public string TextoCadastrar => "Cadastrar Chamadas";

        public void Cadastrar()
        {
            List<Turma> turmas = repositorioTurma.SelecionarTodos();

            CadastrarChamadaForm cadastrarChamada = new CadastrarChamadaForm(turmas);

            if (cadastrarChamada.ShowDialog() == DialogResult.OK)
            {
                Chamada chamada = cadastrarChamada.novaChamada;

                repositorioChamada.Adicionar(chamada);   
            }
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public UserControl ObterListaDados()
        {
            if (listaChamadasControl == null)
                listaChamadasControl = new ListaChamadasControl();

            return listaChamadasControl;
        }
    }
}
