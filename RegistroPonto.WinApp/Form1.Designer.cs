namespace RegistroPonto.WinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrarAluno = new Button();
            btnVisulizarAlunos = new Button();
            SuspendLayout();
            // 
            // btnCadastrarAluno
            // 
            btnCadastrarAluno.Location = new Point(12, 12);
            btnCadastrarAluno.Name = "btnCadastrarAluno";
            btnCadastrarAluno.Size = new Size(189, 64);
            btnCadastrarAluno.TabIndex = 0;
            btnCadastrarAluno.Text = "Cadastrar Aluno";
            btnCadastrarAluno.UseVisualStyleBackColor = true;
            btnCadastrarAluno.Click += btnCadastrarAluno_Click;
            // 
            // btnVisulizarAlunos
            // 
            btnVisulizarAlunos.Location = new Point(207, 13);
            btnVisulizarAlunos.Name = "btnVisulizarAlunos";
            btnVisulizarAlunos.Size = new Size(197, 63);
            btnVisulizarAlunos.TabIndex = 1;
            btnVisulizarAlunos.Text = "Visualizar Alunos";
            btnVisulizarAlunos.UseVisualStyleBackColor = true;
            btnVisulizarAlunos.Click += btnVisulizarAlunos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVisulizarAlunos);
            Controls.Add(btnCadastrarAluno);
            Name = "Form1";
            Text = "Registro do Ponto";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrarAluno;
        private Button btnVisulizarAlunos;
    }
}
