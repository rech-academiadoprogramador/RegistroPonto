namespace RegistroPonto.WinApp.ModuloAluno
{
    public partial class CadastrarAlunoForm : Form
    {
        public IRepositorioAluno repositorioAlunos;
        
        public CadastrarAlunoForm(IRepositorioAluno repositorio)
        {
            InitializeComponent();
            repositorioAlunos = repositorio;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //pegar as informações dos componentes
            int id = Convert.ToInt32( txtId.Text );
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            decimal percentualFrequencia = Convert.ToDecimal(txtPercentualFrequencia.Text);

            Aluno novoAluno = new Aluno(id, nome, telefone, email, percentualFrequencia);

            repositorioAlunos.Adicionar(novoAluno);
        }
    }
}
