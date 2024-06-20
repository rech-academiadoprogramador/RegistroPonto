namespace RegistroPonto.WinApp.ModuloAluno
{
    public class RepositorioAlunoEmMemoria : IRepositorioAluno
    {
        private List<Aluno> alunos;

        public RepositorioAlunoEmMemoria(List<Aluno> alunos)
        {
            this.alunos = alunos;
        }

        public void Adicionar(Aluno novoAluno)
        {
            this.alunos.Add(novoAluno);
        }

        public List<Aluno> SelecionarTodos()
        {
            return this.alunos;
        }       
    }
}
