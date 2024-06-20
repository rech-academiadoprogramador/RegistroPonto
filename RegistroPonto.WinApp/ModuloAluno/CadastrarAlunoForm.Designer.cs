namespace RegistroPonto.WinApp.ModuloAluno
{
    partial class CadastrarAlunoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPercentualFrequencia = new TextBox();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(185, 236);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 49);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(266, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 49);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 26);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 69);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 111);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 152);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // txtId
            // 
            txtId.Location = new Point(95, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(244, 23);
            txtId.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(97, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(244, 23);
            txtNome.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(96, 109);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(244, 23);
            txtTelefone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(97, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 23);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(100, 39);
            label5.TabIndex = 10;
            label5.Text = "Percentual de Frequência:";
            // 
            // txtPercentualFrequencia
            // 
            txtPercentualFrequencia.Enabled = false;
            txtPercentualFrequencia.Location = new Point(98, 191);
            txtPercentualFrequencia.Name = "txtPercentualFrequencia";
            txtPercentualFrequencia.ReadOnly = true;
            txtPercentualFrequencia.Size = new Size(100, 23);
            txtPercentualFrequencia.TabIndex = 11;
            txtPercentualFrequencia.Text = "0";
            // 
            // CadastrarAlunoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 307);
            Controls.Add(txtPercentualFrequencia);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "CadastrarAlunoForm";
            Text = "Cadastrar Alunos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPercentualFrequencia;
    }
}