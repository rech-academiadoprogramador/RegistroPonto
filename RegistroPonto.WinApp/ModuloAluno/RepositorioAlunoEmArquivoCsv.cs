namespace RegistroPonto.WinApp.ModuloAluno
{
    public class RepositorioAlunoEmArquivoCsv : IRepositorioAluno
    {
        private List<Aluno> alunos;

        public RepositorioAlunoEmArquivoCsv(List<Aluno> alunos)
        {
            this.alunos = alunos;
        }

        public void Adicionar(Aluno novoAluno)
        {
            this.alunos.Add(novoAluno);

            string alunosSerializados = string.Empty;

            foreach (Aluno aluno in alunos)
            {
                alunosSerializados += aluno.ToString();
                alunosSerializados += Environment.NewLine;
            }            

            File.WriteAllText(@"C:\temp\registroponto.txt", alunosSerializados);
        }

        public List<Aluno> SelecionarTodos()
        {
            alunos.Clear();

            string alunosDeserializados = File.ReadAllText(@"C:\temp\registroponto.txt");

            string[] linhas = alunosDeserializados.Split(Environment.NewLine);

            foreach (string linha in linhas)
            {
                if (string.IsNullOrEmpty(linha))
                     continue; 

                string[] campos = linha.Split(",");

                int id = Convert.ToInt32(campos[0]);
                string nome = campos[1];
                string telefone = campos[2];
                string email = campos[3];
                decimal percentual = Convert.ToDecimal( campos[4] );

                Aluno aluno = new Aluno(id, nome, telefone, email, percentual);

                alunos.Add(aluno);
            }

            return this.alunos;
        }
    }
}
