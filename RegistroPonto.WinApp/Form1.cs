using RegistroPonto.WinApp.ModuloAluno;

namespace RegistroPonto.WinApp
{
    public partial class Form1 : Form
    {
        CadastrarAlunoForm cadastrarAluno; 
        VisualizarAlunosForm visualizarAlunos = null;
        IRepositorioAluno repositorioAlunos;

        public Form1()
        {
            InitializeComponent();
            
            List<Aluno> alunos = new List<Aluno>();

            repositorioAlunos = new RepositorioAlunoEmJson(alunos);

            cadastrarAluno = new CadastrarAlunoForm(repositorioAlunos);
            visualizarAlunos = new VisualizarAlunosForm(repositorioAlunos);
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            cadastrarAluno.ShowDialog();
        }

        private void btnVisulizarAlunos_Click(object sender, EventArgs e)
        {
            visualizarAlunos.AtualizarLista();
            visualizarAlunos.ShowDialog();
        }
    }


}