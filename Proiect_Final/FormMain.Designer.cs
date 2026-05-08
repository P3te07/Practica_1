namespace Proiect_Final
{
    partial class FormMain
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
            btnMenuClienti = new Button();
            btnMenuAbonamente = new Button();
            btnMenuInregistrari = new Button();
            btnMainReport = new Button();
            SuspendLayout();
            // 
            // btnMenuClienti
            // 
            btnMenuClienti.Font = new Font("Segoe UI", 19F);
            btnMenuClienti.Location = new Point(85, 47);
            btnMenuClienti.Name = "btnMenuClienti";
            btnMenuClienti.Size = new Size(185, 62);
            btnMenuClienti.TabIndex = 0;
            btnMenuClienti.Text = "Clienti";
            btnMenuClienti.UseVisualStyleBackColor = true;
            btnMenuClienti.Click += btnMenuClienti_Click;
            // 
            // btnMenuAbonamente
            // 
            btnMenuAbonamente.Font = new Font("Segoe UI", 19F);
            btnMenuAbonamente.Location = new Point(85, 140);
            btnMenuAbonamente.Name = "btnMenuAbonamente";
            btnMenuAbonamente.Size = new Size(185, 62);
            btnMenuAbonamente.TabIndex = 1;
            btnMenuAbonamente.Text = "Abonamente";
            btnMenuAbonamente.UseVisualStyleBackColor = true;
            btnMenuAbonamente.Click += btnMenuAbonamente_Click;
            // 
            // btnMenuInregistrari
            // 
            btnMenuInregistrari.Font = new Font("Segoe UI", 19F);
            btnMenuInregistrari.Location = new Point(85, 236);
            btnMenuInregistrari.Name = "btnMenuInregistrari";
            btnMenuInregistrari.Size = new Size(185, 62);
            btnMenuInregistrari.TabIndex = 2;
            btnMenuInregistrari.Text = "Inregistrari";
            btnMenuInregistrari.UseVisualStyleBackColor = true;
            btnMenuInregistrari.Click += btnMenuInregistrari_Click;
            // 
            // btnMainReport
            // 
            btnMainReport.Font = new Font("Segoe UI", 19F);
            btnMainReport.Location = new Point(85, 334);
            btnMainReport.Name = "btnMainReport";
            btnMainReport.Size = new Size(185, 62);
            btnMainReport.TabIndex = 3;
            btnMainReport.Text = "Raport";
            btnMainReport.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(btnMainReport);
            Controls.Add(btnMenuInregistrari);
            Controls.Add(btnMenuAbonamente);
            Controls.Add(btnMenuClienti);
            Name = "FormMain";
            Text = "Pagina Principala";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenuClienti;
        private Button btnMenuAbonamente;
        private Button btnMenuInregistrari;
        private Button btnMainReport;
    }
}