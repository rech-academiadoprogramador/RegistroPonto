namespace RegistroPonto.WinApp.ModuloAluno
{
    partial class VisualizarAlunosForm
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
            listBoxAlunos = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBoxAlunos
            // 
            listBoxAlunos.FormattingEnabled = true;
            listBoxAlunos.ItemHeight = 15;
            listBoxAlunos.Location = new Point(12, 12);
            listBoxAlunos.Name = "listBoxAlunos";
            listBoxAlunos.Size = new Size(776, 364);
            listBoxAlunos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(656, 397);
            button1.Name = "button1";
            button1.Size = new Size(132, 41);
            button1.TabIndex = 1;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // VisualizarAlunosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBoxAlunos);
            Name = "VisualizarAlunosForm";
            Text = "VisualizarAlunosForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxAlunos;
        private Button button1;
    }
}