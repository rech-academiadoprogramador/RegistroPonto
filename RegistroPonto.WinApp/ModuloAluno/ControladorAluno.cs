using RegistroPonto.WinApp.Compartilhado;

namespace RegistroPonto.WinApp.ModuloAluno
{
    public class ControladorAluno : IControlador
    {
        IRepositorioAluno repositorioAlunos;
        ListaAlunosControl listaAlunos;

        public ControladorAluno(IRepositorioAluno repositorioAlunos)
        {
            this.repositorioAlunos = repositorioAlunos;
        }

        public string TextoCadastrar
        {
            get { return "Cadastrar Alunos"; }
        }

        public void Cadastrar()
        {
            CadastrarAlunoForm cadastrarAluno = new CadastrarAlunoForm(null);
            DialogResult opcao = cadastrarAluno.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                Aluno a = cadastrarAluno.novoAluno;

                repositorioAlunos.Adicionar(a);

                AtualizarListaAlunos();
            }
        }

        public void Editar()
        {
            Aluno alunoSelecionado = listaAlunos.ObterAlunoSelecionado();

            if (alunoSelecionado == null)
            {
                MessageBox.Show("Selecione um aluno!");
                return;
            }

            CadastrarAlunoForm cadastrarAluno = new CadastrarAlunoForm(alunoSelecionado);
            DialogResult opcao = cadastrarAluno.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                Aluno a = cadastrarAluno.novoAluno;

                repositorioAlunos.Editar(a);

                AtualizarListaAlunos();
            }
        }

        public void Excluir()
        {
            Aluno alunoSelecionado = listaAlunos.ObterAlunoSelecionado();

            if (alunoSelecionado == null)
            {
                MessageBox.Show("Selecione um aluno!");
                return;
            }

            DialogResult opcao = MessageBox.Show("Tem certeza que deseja excluir?");

            if (opcao == DialogResult.OK)
            {
                repositorioAlunos.Excluir(alunoSelecionado);
                AtualizarListaAlunos();
            }
        }

        public UserControl ObterListaDados()
        {
            if (listaAlunos == null)
                listaAlunos = new ListaAlunosControl();

            AtualizarListaAlunos();

            return listaAlunos;
        }

        private void AtualizarListaAlunos()
        {
            List<Aluno> alunos = repositorioAlunos.SelecionarTodos();

            listaAlunos.AtualizarRegistros(alunos);            
        }
    }
}
