using RegistroPonto.WinApp.Compartilhado;
using RegistroPonto.WinApp.ModuloAluno;
using RegistroPonto.WinApp.ModuloAula;
using RegistroPonto.WinApp.ModuloTurma;

namespace RegistroPonto.WinApp
{
    public partial class TelaPrincipal : Form
    {
        IRepositorioAluno repositorioAlunos;
        IControlador controlador;

        ControladorAluno controladorAluno;

        public TelaPrincipal()
        {
            InitializeComponent();

            repositorioAlunos = new RepositorioAlunoEmJson(new List<Aluno>());
            controladorAluno = new ControladorAluno(repositorioAlunos);

            controlador = controladorAluno;
            ConfigurarTela(controlador);
        }

        private void moduloEscolhido_Click(object sender, EventArgs e)
        {
            RadioButton moduloEscolhido = (RadioButton)sender;

            if (moduloEscolhido.Text == "Gerenciar Alunos")
                controlador = controladorAluno;

            if (moduloEscolhido.Text == "Gerenciar Turmas")
                controlador = new ControladorTurma();

            if (moduloEscolhido.Text == "Gerenciar Aulas")
                controlador = new ControladorAula();

            ConfigurarTela(controlador);
        }

        private void ConfigurarTela(IControlador controlador)
        {
            panel1.Controls.Clear();
            UserControl lista = controlador.ObterListaDados();
            lista.Dock = DockStyle.Fill;
            panel1.Controls.Add(lista);

            btnCadastrarRegistro.Text = controlador.TextoCadastrar;
        }

        private void btnCadastrarRegistro_Click(object sender, EventArgs e)
        {
            controlador.Cadastrar();
        }

        private void btnEditarRegistros_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluirRegistro_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
    }
}