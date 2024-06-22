namespace RegistroPonto.WinApp.ModuloChamada
{
    partial class ListaChamadasControl
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
            listBoxChamadas = new ListBox();
            SuspendLayout();
            // 
            // listBoxChamadas
            // 
            listBoxChamadas.Dock = DockStyle.Fill;
            listBoxChamadas.FormattingEnabled = true;
            listBoxChamadas.ItemHeight = 15;
            listBoxChamadas.Location = new Point(0, 0);
            listBoxChamadas.Name = "listBoxChamadas";
            listBoxChamadas.Size = new Size(610, 454);
            listBoxChamadas.TabIndex = 0;
            // 
            // ListaChamadasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxChamadas);
            Name = "ListaChamadasControl";
            Size = new Size(610, 454);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxChamadas;
    }
}
