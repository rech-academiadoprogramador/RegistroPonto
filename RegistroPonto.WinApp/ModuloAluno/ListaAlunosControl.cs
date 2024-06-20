namespace RegistroPonto.WinApp.ModuloAluno
{
    public partial class ListaAlunosControl : UserControl
    {
        public ListaAlunosControl()
        {
            InitializeComponent();
        }

        internal void AtualizarRegistros(List<Aluno> alunos)
        {
            listaAlunos.Items.Clear();

            foreach (Aluno aluno in alunos)
            {
                listaAlunos.Items.Add(aluno);
            }
        }

        internal Aluno ObterAlunoSelecionado()
        {
            return (Aluno)listaAlunos.SelectedItem;
        }
    }
}
