namespace RegistroPonto.WinApp.Compartilhado
{
    public interface IControlador
    {
        string TextoCadastrar { get; }

        void Cadastrar();
        
        void Editar();

        void Excluir();

        UserControl ObterListaDados();
    }
}