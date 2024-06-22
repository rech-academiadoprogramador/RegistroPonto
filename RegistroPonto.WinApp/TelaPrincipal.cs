using RegistroPonto.WinApp.Compartilhado;
using RegistroPonto.WinApp.ModuloAluno;
using RegistroPonto.WinApp.ModuloAula;
using RegistroPonto.WinApp.ModuloChamada;
using RegistroPonto.WinApp.ModuloTurma;

namespace RegistroPonto.WinApp
{
    public partial class TelaPrincipal : Form
    {
        IRepositorioAluno repositorioAlunos;
        ControladorAluno controladorAluno;

        IRepositorioChamada repositorioChamada;
        IRepositorioTurma repositorioTurma;
        ControladorChamada controladorChamada;

        IRepositorioAula repositorioAula;

        IControlador controlador;


        public TelaPrincipal()
        {
            InitializeComponent();

            Turma turma1 = new Turma(1, "Tarde", 2024);
            Turma turma2 = new Turma(2, "Noite", 2024);

            Aluno aluno1 = new Aluno(1, "a", "a", "a");
            Aluno aluno2 = new Aluno(2, "b", "b", "b");
            Aluno aluno3 = new Aluno(3, "c", "c", "c");
            Aluno aluno4 = new Aluno(4, "d", "d", "d");

            turma1.Alunos.Add(aluno1);
            turma1.Alunos.Add(aluno2);
            turma1.Alunos.Add(aluno3);
            turma1.Alunos.Add(aluno4);

            Aluno aluno11 = new Aluno(11, "e", "e", "e");
            Aluno aluno12 = new Aluno(12, "f", "f", "f");
            Aluno aluno13 = new Aluno(13, "g", "g", "g");
            Aluno aluno14 = new Aluno(14, "h", "h", "h");

            turma2.Alunos.Add(aluno11);
            turma2.Alunos.Add(aluno12);
            turma2.Alunos.Add(aluno13);
            turma2.Alunos.Add(aluno14);

            Aula aula1 = new Aula(1, "Revisão 1", 10);
            Aula aula2 = new Aula(2, "Revisão 2", 10);
            Aula aula3 = new Aula(3, "Revisão 3", 10);

            turma1.Aulas.Add(aula1);
            turma1.Aulas.Add(aula2);
            turma1.Aulas.Add(aula3);

            turma2.Aulas.Add(new Aula(11, "Revisão 21", 10));
            turma2.Aulas.Add(new Aula(12, "Revisão 22", 10));
            turma2.Aulas.Add(new Aula(13, "Revisão 23", 10));
            turma2.Aulas.Add(new Aula(11, "Revisão 31", 10));
            turma2.Aulas.Add(new Aula(12, "Revisão 32", 10));
            turma2.Aulas.Add(new Aula(13, "Revisão 33", 10));
           
            repositorioAlunos = new RepositorioAlunoEmJson(new List<Aluno>());
            repositorioAlunos.Adicionar(aluno1);
            repositorioAlunos.Adicionar(aluno2);
            repositorioAlunos.Adicionar(aluno3);
            repositorioAlunos.Adicionar(aluno4);

            repositorioAlunos.Adicionar(aluno11);
            repositorioAlunos.Adicionar(aluno12);
            repositorioAlunos.Adicionar(aluno13);
            repositorioAlunos.Adicionar(aluno14);

            repositorioAula = new RepositorioAulaEmJson(new List<Aula>());
            repositorioAula.Adicionar(aula1);
            repositorioAula.Adicionar(aula2);
            repositorioAula.Adicionar(aula3);

            repositorioChamada = new RepositorioChamadaEmJson(new List<Chamada>());   
            
            repositorioTurma = new RepositorioTurmaEmJson(new List<Turma>());
            repositorioTurma.Adicionar(turma1);
            repositorioTurma.Adicionar(turma2);

            controladorChamada = new ControladorChamada(repositorioChamada, repositorioTurma);
            controladorAluno = new ControladorAluno(repositorioAlunos);

            controlador = controladorAluno;
            ConfigurarTela(controlador);
        }

        private void moduloEscolhido_Click(object sender, EventArgs e)
        {
            RadioButton moduloEscolhido = (RadioButton)sender;

            if (moduloEscolhido.Text == "Gerenciar Alunos")
                controlador = controladorAluno;

            else if (moduloEscolhido.Text == "Gerenciar Chamadas")
                controlador = controladorChamada;

            else if (moduloEscolhido.Text == "Gerenciar Turmas")
                controlador = new ControladorTurma();

            else if (moduloEscolhido.Text == "Gerenciar Aulas")
                controlador = new ControladorAula();


            ConfigurarTela(controlador);
        }

        private void ConfigurarTela(IControlador controlador)
        {
            panel1.Controls.Clear();
            UserControl lista = controlador.ObterListaDados();
            lista.Dock = DockStyle.Fill;
            panel1.Controls.Add(lista);

            btnCadastrarRegistro.Text = controlador.TextoCadastrar;
        }

        private void btnCadastrarRegistro_Click(object sender, EventArgs e)
        {
            controlador.Cadastrar();
        }

        private void btnEditarRegistros_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluirRegistro_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
    }
}