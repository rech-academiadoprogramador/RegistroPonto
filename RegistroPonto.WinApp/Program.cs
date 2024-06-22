using RegistroPonto.WinApp.ModuloAluno;
using RegistroPonto.WinApp.ModuloTurma;

namespace RegistroPonto.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Aluno aluno = new Aluno(1, "MAtheus", "123456", "matheus@gmail");
            
            
            decimal percentualFrequencia = aluno.PercentualFrequencia; //aqui vou usar o get e o return

            //aluno.Ausencias.Add(new Ausencia());
            //aluno.Ausencias.Add(new Ausencia());

            //aluno.Presencas.Add(new Presenca());
            //aluno.Presencas.Add(new Presenca());
            //aluno.Presencas.Add(new Presenca());

            //OperacaoMatematica operacao = delegate(int x, int y)
            //{
            //    return x + y;
            //};

            //int resultado = operacao(2, 8);

            //operacao = delegate (int x, int y)
            //{
            //    return x - y;
            //};

            //resultado = operacao(2, 8);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipal());
        }

        delegate int OperacaoMatematica(int a, int b);
    }

}