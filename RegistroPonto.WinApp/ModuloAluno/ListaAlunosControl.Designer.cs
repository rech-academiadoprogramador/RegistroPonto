namespace RegistroPonto.WinApp.ModuloAluno
{
    partial class ListaAlunosControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listaAlunos = new ListBox();
            SuspendLayout();
            // 
            // listAlunos
            // 
            listaAlunos.Dock = DockStyle.Fill;
            listaAlunos.FormattingEnabled = true;
            listaAlunos.ItemHeight = 15;
            listaAlunos.Location = new Point(0, 0);
            listaAlunos.Name = "listAlunos";
            listaAlunos.Size = new Size(482, 437);
            listaAlunos.TabIndex = 0;
            // 
            // ListaAlunosControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listaAlunos);
            Name = "ListaAlunosControl";
            Size = new Size(482, 437);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listaAlunos;
    }
}
