namespace RegistroPonto.WinApp.ModuloAluno
{
    public partial class VisualizarAlunosForm : Form
    {
        public IRepositorioAluno repositorioAluno;

        public VisualizarAlunosForm(IRepositorioAluno repositorioAluno)
        {
            InitializeComponent();
            this.repositorioAluno = repositorioAluno;
        }

        public void AtualizarLista()
        {
            listBoxAlunos.Items.Clear();

            List<Aluno> alunos = repositorioAluno.SelecionarTodos();

            foreach (Aluno aluno in alunos)
            {
                listBoxAlunos.Items.Add(aluno);
            }
        }
    }
}
