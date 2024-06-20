namespace RegistroPonto.WinApp
{
    partial class TelaPrincipal
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
            btnCadastrarRegistro = new Button();
            rdbGerenciarAlunos = new RadioButton();
            rdbGerenciarTurmas = new RadioButton();
            rdbGerenciarAulas = new RadioButton();
            panel1 = new Panel();
            btnEditarRegistros = new Button();
            btnExcluirRegistro = new Button();
            SuspendLayout();
            // 
            // btnCadastrarRegistro
            // 
            btnCadastrarRegistro.Location = new Point(31, 65);
            btnCadastrarRegistro.Name = "btnCadastrarRegistro";
            btnCadastrarRegistro.Size = new Size(189, 64);
            btnCadastrarRegistro.TabIndex = 0;
            btnCadastrarRegistro.Text = "Cadastrar Registros";
            btnCadastrarRegistro.UseVisualStyleBackColor = true;
            btnCadastrarRegistro.Click += btnCadastrarRegistro_Click;
            // 
            // rdbGerenciarAlunos
            // 
            rdbGerenciarAlunos.AutoSize = true;
            rdbGerenciarAlunos.Checked = true;
            rdbGerenciarAlunos.Location = new Point(37, 22);
            rdbGerenciarAlunos.Name = "rdbGerenciarAlunos";
            rdbGerenciarAlunos.Size = new Size(115, 19);
            rdbGerenciarAlunos.TabIndex = 2;
            rdbGerenciarAlunos.TabStop = true;
            rdbGerenciarAlunos.Text = "Gerenciar Alunos";
            rdbGerenciarAlunos.UseVisualStyleBackColor = true;
            rdbGerenciarAlunos.Click += moduloEscolhido_Click;
            // 
            // rdbGerenciarTurmas
            // 
            rdbGerenciarTurmas.AutoSize = true;
            rdbGerenciarTurmas.Location = new Point(158, 22);
            rdbGerenciarTurmas.Name = "rdbGerenciarTurmas";
            rdbGerenciarTurmas.Size = new Size(117, 19);
            rdbGerenciarTurmas.TabIndex = 3;
            rdbGerenciarTurmas.Text = "Gerenciar Turmas";
            rdbGerenciarTurmas.UseVisualStyleBackColor = true;
            rdbGerenciarTurmas.Click += moduloEscolhido_Click;
            // 
            // rdbGerenciarAulas
            // 
            rdbGerenciarAulas.AutoSize = true;
            rdbGerenciarAulas.Location = new Point(281, 22);
            rdbGerenciarAulas.Name = "rdbGerenciarAulas";
            rdbGerenciarAulas.Size = new Size(107, 19);
            rdbGerenciarAulas.TabIndex = 4;
            rdbGerenciarAulas.Text = "Gerenciar Aulas";
            rdbGerenciarAulas.UseVisualStyleBackColor = true;
            rdbGerenciarAulas.Click += moduloEscolhido_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(31, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 405);
            panel1.TabIndex = 5;
            // 
            // btnEditarRegistros
            // 
            btnEditarRegistros.Location = new Point(226, 66);
            btnEditarRegistros.Name = "btnEditarRegistros";
            btnEditarRegistros.Size = new Size(189, 62);
            btnEditarRegistros.TabIndex = 6;
            btnEditarRegistros.Text = "Editar Registros";
            btnEditarRegistros.UseVisualStyleBackColor = true;
            btnEditarRegistros.Click += btnEditarRegistros_Click;
            // 
            // btnExcluirRegistro
            // 
            btnExcluirRegistro.Location = new Point(421, 66);
            btnExcluirRegistro.Name = "btnExcluirRegistro";
            btnExcluirRegistro.Size = new Size(189, 63);
            btnExcluirRegistro.TabIndex = 7;
            btnExcluirRegistro.Text = "Excluir Registros";
            btnExcluirRegistro.UseVisualStyleBackColor = true;
            btnExcluirRegistro.Click += btnExcluirRegistro_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(btnExcluirRegistro);
            Controls.Add(btnEditarRegistros);
            Controls.Add(panel1);
            Controls.Add(rdbGerenciarAulas);
            Controls.Add(rdbGerenciarTurmas);
            Controls.Add(rdbGerenciarAlunos);
            Controls.Add(btnCadastrarRegistro);
            Name = "TelaPrincipal";
            Text = "Registro do Ponto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarRegistro;
        private RadioButton rdbGerenciarAlunos;
        private RadioButton rdbGerenciarTurmas;
        private RadioButton rdbGerenciarAulas;
        private Panel panel1;
        private Button btnEditarRegistros;
        private Button btnExcluirRegistro;
    }
}
