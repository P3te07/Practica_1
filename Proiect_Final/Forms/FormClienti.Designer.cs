namespace Proiect_Final
{
    partial class FormClienti
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
            btnAdaugaCl = new Button();
            btnDeleteCl = new Button();
            btnModificaCl = new Button();
            txtEmailCl = new TextBox();
            txtTelefonCl = new TextBox();
            txtDataNasterii = new TextBox();
            txtNumePrenume = new TextBox();
            txtSearch = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvClienti = new DataGridView();
            btnRefreshCl = new Button();
            btnCautaCl = new Button();
            label5 = new Label();
            txtIdClientCl = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClienti).BeginInit();
            SuspendLayout();
            // 
            // btnAdaugaCl
            // 
            btnAdaugaCl.Location = new Point(650, 319);
            btnAdaugaCl.Name = "btnAdaugaCl";
            btnAdaugaCl.Size = new Size(82, 26);
            btnAdaugaCl.TabIndex = 30;
            btnAdaugaCl.Text = "Adauga";
            btnAdaugaCl.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCl
            // 
            btnDeleteCl.Location = new Point(650, 399);
            btnDeleteCl.Name = "btnDeleteCl";
            btnDeleteCl.Size = new Size(82, 26);
            btnDeleteCl.TabIndex = 29;
            btnDeleteCl.Text = "Sterge";
            btnDeleteCl.UseVisualStyleBackColor = true;
            // 
            // btnModificaCl
            // 
            btnModificaCl.Location = new Point(650, 357);
            btnModificaCl.Name = "btnModificaCl";
            btnModificaCl.Size = new Size(82, 26);
            btnModificaCl.TabIndex = 28;
            btnModificaCl.Text = "Modifica";
            btnModificaCl.UseVisualStyleBackColor = true;
            // 
            // txtEmailCl
            // 
            txtEmailCl.Location = new Point(421, 379);
            txtEmailCl.Name = "txtEmailCl";
            txtEmailCl.Size = new Size(145, 23);
            txtEmailCl.TabIndex = 27;
            // 
            // txtTelefonCl
            // 
            txtTelefonCl.Location = new Point(421, 327);
            txtTelefonCl.Name = "txtTelefonCl";
            txtTelefonCl.Size = new Size(145, 23);
            txtTelefonCl.TabIndex = 24;
            // 
            // txtDataNasterii
            // 
            txtDataNasterii.Location = new Point(136, 379);
            txtDataNasterii.Name = "txtDataNasterii";
            txtDataNasterii.Size = new Size(145, 23);
            txtDataNasterii.TabIndex = 22;
            // 
            // txtNumePrenume
            // 
            txtNumePrenume.Location = new Point(136, 327);
            txtNumePrenume.Name = "txtNumePrenume";
            txtNumePrenume.Size = new Size(145, 23);
            txtNumePrenume.TabIndex = 20;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(332, 23);
            txtSearch.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 382);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 26;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 330);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 25;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 382);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 23;
            label2.Text = "Data Nasterii";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 330);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 21;
            label1.Text = "Nume Prenume";
            // 
            // dgvClienti
            // 
            dgvClienti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClienti.Location = new Point(16, 88);
            dgvClienti.Name = "dgvClienti";
            dgvClienti.ReadOnly = true;
            dgvClienti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClienti.Size = new Size(735, 211);
            dgvClienti.TabIndex = 19;
            dgvClienti.SelectionChanged += dgvClienti_SelectionChanged;
            // 
            // btnRefreshCl
            // 
            btnRefreshCl.Location = new Point(535, 44);
            btnRefreshCl.Name = "btnRefreshCl";
            btnRefreshCl.Size = new Size(82, 26);
            btnRefreshCl.TabIndex = 18;
            btnRefreshCl.Text = "Refresh";
            btnRefreshCl.UseVisualStyleBackColor = true;
            // 
            // btnCautaCl
            // 
            btnCautaCl.Location = new Point(373, 44);
            btnCautaCl.Name = "btnCautaCl";
            btnCautaCl.Size = new Size(82, 26);
            btnCautaCl.TabIndex = 17;
            btnCautaCl.Text = "Cauta";
            btnCautaCl.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 426);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 31;
            label5.Text = "ID";
            // 
            // txtIdClientCl
            // 
            txtIdClientCl.Location = new Point(40, 423);
            txtIdClientCl.Name = "txtIdClientCl";
            txtIdClientCl.Size = new Size(67, 23);
            txtIdClientCl.TabIndex = 32;
            // 
            // FormClienti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdClientCl);
            Controls.Add(label5);
            Controls.Add(btnAdaugaCl);
            Controls.Add(btnDeleteCl);
            Controls.Add(btnModificaCl);
            Controls.Add(txtEmailCl);
            Controls.Add(txtTelefonCl);
            Controls.Add(txtDataNasterii);
            Controls.Add(txtNumePrenume);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvClienti);
            Controls.Add(btnRefreshCl);
            Controls.Add(btnCautaCl);
            Name = "FormClienti";
            Text = "Clienti";
            FormClosed += FormClienti_FormClosed;
            Load += FormClienti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClienti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdaugaCl;
        private Button btnDeleteCl;
        private Button btnModificaCl;
        private TextBox txtEmailCl;
        private TextBox txtTelefonCl;
        private TextBox txtDataNasterii;
        private TextBox txtNumePrenume;
        private TextBox txtSearch;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvClienti;
        private Button btnRefreshCl;
        private Button btnCautaCl;
        private Label label5;
        private TextBox txtIdClientCl;
    }
}
