using System.Text.Json;

namespace RegistroPonto.WinApp.ModuloAluno
{
    public class RepositorioAlunoEmJson : IRepositorioAluno
    {
        private List<Aluno> alunos;

        public RepositorioAlunoEmJson(List<Aluno> alunos)
        {
            this.alunos = alunos;
        }

        public void Adicionar(Aluno novoAluno)
        {
            this.alunos.Add(novoAluno);

            SelerializarAlunos();
        }

        public void Editar(Aluno alunoAtualizado)
        {
            Aluno aluno2 = alunos.Find(a => a.Id == alunoAtualizado.Id)!;

            if (aluno2 == null)
                return;

            aluno2.AtualizarDados(alunoAtualizado);

            SelerializarAlunos();
        }

        public void Excluir(Aluno aluno)
        {
            alunos.Remove(aluno);

            SelerializarAlunos();
        }

        public List<Aluno> SelecionarTodos()
        {
            string arquivo = File.ReadAllText(@"C:\temp\registroponto.json");

            this.alunos = JsonSerializer.Deserialize<List<Aluno>>(arquivo)!;

            return alunos;
        }

        private void SelerializarAlunos()
        {
            string arquivo = JsonSerializer.Serialize(alunos);

            File.WriteAllText(@"C:\temp\registroponto.json", arquivo);
        }

    }
}
