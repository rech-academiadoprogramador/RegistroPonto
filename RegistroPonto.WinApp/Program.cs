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