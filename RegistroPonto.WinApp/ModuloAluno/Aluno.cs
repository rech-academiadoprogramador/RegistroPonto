
using RegistroPonto.WinApp.Compartilhado;
using RegistroPonto.WinApp.ModuloAula;
using RegistroPonto.WinApp.ModuloChamada;
using System.Diagnostics;

namespace RegistroPonto.WinApp.ModuloAluno
{
    public class Aluno : EntidadeBase
    {

        public Aluno(int id, string nome, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;

            Participacoes = new List<Participacao>();
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Participacao> Participacoes { get; set; }

        public decimal PercentualFrequencia
        {
            get
            {
                if (Participacoes.Count > 0) 
                    return Participacoes.Count(p => p is Presenca) / Participacoes.Count * 100;

                return 0;
            }
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Telefone}, {Email}, {PercentualFrequencia}";
        }

        public void AtualizarDados(Aluno alunoAtualizado)
        {
            Nome = alunoAtualizado.Nome;
            Telefone = alunoAtualizado.Telefone;
            Email = alunoAtualizado.Email;
        }

        public void RegistrarAusencia(Participacao ausencia)
        {
            Participacoes.Add(ausencia);
        }

        public void RegistrarPresenca(Participacao presenca)
        {
            Participacoes.Add(presenca);
        }
    }



}
