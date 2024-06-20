namespace RegistroPonto.WinApp.ModuloAluno
{
    public class Aluno
    {       
        public Aluno(int id, string nome, string telefone, string email, decimal percentualFrequencia)
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
            this.PercentualFrequencia = percentualFrequencia;

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public decimal PercentualFrequencia { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Telefone}, {Email}, {PercentualFrequencia}";
        }
    }
}
