
using RegistroPonto.WinApp.Compartilhado;

namespace RegistroPonto.WinApp.ModuloAula
{
    public class Aula : EntidadeBase
    {
        public Aula(int id, string conteudo, int semana)
        {
            Id = id;
            Conteudo = conteudo;
            Semana = semana;
        }


        public string Conteudo { get; set; }

        public int Semana { get; set; }

        public override string? ToString()
        {
            return $"Id: {Id}, {Conteudo}, Semana {Semana}";
        }

        internal void AtualizarDados(Aula aulaAtualizada)
        {
            throw new NotImplementedException();
        }
    }
}
