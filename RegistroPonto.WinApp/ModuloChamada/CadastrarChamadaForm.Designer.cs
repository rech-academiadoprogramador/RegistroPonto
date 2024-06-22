namespace RegistroPonto.WinApp.ModuloChamada
{
    partial class CadastrarChamadaForm
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
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            cmbTurmas = new ComboBox();
            cmbAulas = new ComboBox();
            listBoxParticipacao = new CheckedListBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(87, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(103, 23);
            txtId.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 111);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 16;
            label3.Text = "Aulas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 69);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 15;
            label2.Text = "Turmas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 26);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 14;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(273, 589);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 49);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(192, 589);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 49);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // cmbTurmas
            // 
            cmbTurmas.FormattingEnabled = true;
            cmbTurmas.Location = new Point(87, 66);
            cmbTurmas.Name = "cmbTurmas";
            cmbTurmas.Size = new Size(261, 23);
            cmbTurmas.TabIndex = 24;
            cmbTurmas.SelectedIndexChanged += cmbAulas_SelectedIndexChanged;
            // 
            // cmbAulas
            // 
            cmbAulas.FormattingEnabled = true;
            cmbAulas.Location = new Point(87, 108);
            cmbAulas.Name = "cmbAulas";
            cmbAulas.Size = new Size(261, 23);
            cmbAulas.TabIndex = 25;
            // 
            // listBoxParticipacao
            // 
            listBoxParticipacao.Dock = DockStyle.Fill;
            listBoxParticipacao.FormattingEnabled = true;
            listBoxParticipacao.Location = new Point(3, 19);
            listBoxParticipacao.Name = "listBoxParticipacao";
            listBoxParticipacao.Size = new Size(312, 409);
            listBoxParticipacao.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxParticipacao);
            groupBox1.Location = new Point(30, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 431);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Participação:";
            // 
            // CadastrarChamadaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 664);
            Controls.Add(groupBox1);
            Controls.Add(cmbAulas);
            Controls.Add(cmbTurmas);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastrarChamadaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Chamadas";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private ComboBox cmbTurmas;
        private ComboBox cmbAulas;
        private CheckedListBox listBoxParticipacao;
        private GroupBox groupBox1;
    }
}