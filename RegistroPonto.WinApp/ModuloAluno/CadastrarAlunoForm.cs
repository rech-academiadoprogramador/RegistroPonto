namespace RegistroPonto.WinApp.ModuloAluno
{
    public partial class CadastrarAlunoForm : Form
    {
        public Aluno novoAluno;

        public CadastrarAlunoForm(Aluno alunoSelecionado)
        {
            InitializeComponent();
            novoAluno = alunoSelecionado;
            AtualizarFormalarioComDadosDoAluno(alunoSelecionado);
        }

        private void AtualizarFormalarioComDadosDoAluno(Aluno alunoSelecionado)
        {
            if (alunoSelecionado != null)
            {
                txtId.Text = alunoSelecionado.Id.ToString();
                txtNome.Text = alunoSelecionado.Nome;
                txtTelefone.Text = alunoSelecionado.Telefone;
                txtEmail.Text = alunoSelecionado.Email;
                txtPercentualFrequencia.Text = alunoSelecionado.PercentualFrequencia.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {            
            novoAluno = ObterDadosAluno();
        }

        private Aluno ObterDadosAluno()
        {
            //pegar as informações dos componentes
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            decimal percentualFrequencia = Convert.ToDecimal(txtPercentualFrequencia.Text);

            return new Aluno(id, nome, telefone, email, percentualFrequencia);
        }
    }
}
