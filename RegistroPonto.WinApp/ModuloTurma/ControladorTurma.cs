using RegistroPonto.WinApp.Compartilhado;

namespace RegistroPonto.WinApp.ModuloTurma
{
    public class ControladorTurma : IControlador
    {
        public string TextoCadastrar
        {
            get { return "Cadastrar Turmas"; }
        }
        public void Cadastrar()
        {
            CadastrarTurmaForm cadastrarTurma = new CadastrarTurmaForm();
            cadastrarTurma.ShowDialog();
        }

        public void Editar()
        {
            CadastrarTurmaForm cadastrarTurma = new CadastrarTurmaForm();
            cadastrarTurma.ShowDialog();
        }

        public void Excluir()
        {
        }

        public UserControl ObterListaDados()
        {
            return new UserControl();
        }
    }
}
