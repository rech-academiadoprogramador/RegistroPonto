using RegistroPonto.WinApp.ModuloAluno;

namespace RegistroPonto.WinApp.ModuloTurma
{
    internal class Turma
    {
        public int Id { get; set; }
        public string Periodo { get; set; }
        public int Ano { get; set; }

        public List<Aluno> Alunos { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, {Periodo}, {Ano}";
        }
    }
}
