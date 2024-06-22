using RegistroPonto.WinApp.ModuloAluno;
using RegistroPonto.WinApp.ModuloAula;
using RegistroPonto.WinApp.ModuloTurma;

namespace RegistroPonto.WinApp.ModuloChamada
{
    public partial class CadastrarChamadaForm : Form
    {
        public Chamada novaChamada;

        public CadastrarChamadaForm(List<Turma> turmas)
        {
            InitializeComponent();

            foreach (Turma turma in turmas)
            {
                cmbTurmas.Items.Add(turma);
            }
        }

        private void cmbAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turma turmaSelecionada = (Turma)cmbTurmas.SelectedItem;

            cmbAulas.Items.Clear();

            foreach (Aula aula in turmaSelecionada.Aulas)
            {
                cmbAulas.Items.Add(aula);
            }

            listBoxParticipacao.Items.Clear();

            foreach (Aluno aluno in turmaSelecionada.Alunos)
            {
                listBoxParticipacao.Items.Add(aluno);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Turma turma = (Turma)cmbTurmas.SelectedItem;
            Aula aula = cmbAulas.SelectedItem as Aula;

            novaChamada = new Chamada(aula, turma);
            
            List<Aluno> alunosPresentes = listBoxParticipacao.CheckedItems
                .Cast<Aluno>()
                .ToList();

            List<Aluno> alunosAusentes = listBoxParticipacao.Items
                .Cast<Aluno>()
                .Except(alunosPresentes)
                .ToList();

            foreach (Aluno aluno in alunosPresentes)
            {
                novaChamada.RegistrarPresenca(aluno);
            }

            foreach (Aluno aluno in alunosAusentes)
            {
                novaChamada.RegistrarAusencia(aluno);
            }


        }
    }
}
