using RegistroPonto.WinApp.Compartilhado;

namespace RegistroPonto.WinApp.ModuloAula
{
    public class ControladorAula : IControlador
    {
        public string TextoCadastrar
        {
            get { return "Cadastrar Aulas"; }
        }
        public void Cadastrar()
        {
            CadastrarAulaForm cadastrarAula = new CadastrarAulaForm();
            cadastrarAula.ShowDialog();
        }

        public void Editar()
        {
            CadastrarAulaForm cadastrarAula = new CadastrarAulaForm();
            cadastrarAula.ShowDialog();
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
