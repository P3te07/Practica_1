namespace Proiect_Final
{
    partial class FormInregistrari
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
            btnAdaugaIn = new Button();
            btnDeleteIn = new Button();
            btnModificaIn = new Button();
            txtDataFinish = new TextBox();
            txtDataStart = new TextBox();
            txtIdAbonament = new TextBox();
            txtIdClient = new TextBox();
            txtSearchIn = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dgvInregistrari = new DataGridView();
            btnRefreshIn = new Button();
            btnSearchIn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInregistrari).BeginInit();
            SuspendLayout();
            // 
            // btnAdaugaIn
            // 
            btnAdaugaIn.Location = new Point(650, 307);
            btnAdaugaIn.Name = "btnAdaugaIn";
            btnAdaugaIn.Size = new Size(82, 26);
            btnAdaugaIn.TabIndex = 31;
            btnAdaugaIn.Text = "Adauga";
            btnAdaugaIn.UseVisualStyleBackColor = true;
            // 
            // btnDeleteIn
            // 
            btnDeleteIn.Location = new Point(650, 398);
            btnDeleteIn.Name = "btnDeleteIn";
            btnDeleteIn.Size = new Size(82, 26);
            btnDeleteIn.TabIndex = 30;
            btnDeleteIn.Text = "Sterge";
            btnDeleteIn.UseVisualStyleBackColor = true;
            // 
            // btnModificaIn
            // 
            btnModificaIn.Location = new Point(650, 355);
            btnModificaIn.Name = "btnModificaIn";
            btnModificaIn.Size = new Size(82, 26);
            btnModificaIn.TabIndex = 29;
            btnModificaIn.Text = "Modifica";
            btnModificaIn.UseVisualStyleBackColor = true;
            // 
            // txtDataFinish
            // 
            txtDataFinish.Location = new Point(449, 381);
            txtDataFinish.Name = "txtDataFinish";
            txtDataFinish.Size = new Size(145, 23);
            txtDataFinish.TabIndex = 28;
            // 
            // txtDataStart
            // 
            txtDataStart.Location = new Point(449, 329);
            txtDataStart.Name = "txtDataStart";
            txtDataStart.Size = new Size(145, 23);
            txtDataStart.TabIndex = 25;
            // 
            // txtIdAbonament
            // 
            txtIdAbonament.Location = new Point(136, 381);
            txtIdAbonament.Name = "txtIdAbonament";
            txtIdAbonament.Size = new Size(145, 23);
            txtIdAbonament.TabIndex = 23;
            // 
            // txtIdClient
            // 
            txtIdClient.Location = new Point(136, 329);
            txtIdClient.Name = "txtIdClient";
            txtIdClient.Size = new Size(145, 23);
            txtIdClient.TabIndex = 21;
            // 
            // txtSearchIn
            // 
            txtSearchIn.Location = new Point(16, 46);
            txtSearchIn.Name = "txtSearchIn";
            txtSearchIn.Size = new Size(332, 23);
            txtSearchIn.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(354, 387);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 27;
            label9.Text = "Data Finish";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(354, 335);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 26;
            label10.Text = "Data Start";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 387);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 24;
            label11.Text = "Id Abonament";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 335);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 22;
            label12.Text = "Id Client";
            // 
            // dgvInregistrari
            // 
            dgvInregistrari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInregistrari.Location = new Point(16, 90);
            dgvInregistrari.Name = "dgvInregistrari";
            dgvInregistrari.Size = new Size(735, 211);
            dgvInregistrari.TabIndex = 20;
            // 
            // btnRefreshIn
            // 
            btnRefreshIn.Location = new Point(535, 46);
            btnRefreshIn.Name = "btnRefreshIn";
            btnRefreshIn.Size = new Size(82, 26);
            btnRefreshIn.TabIndex = 19;
            btnRefreshIn.Text = "Refresh";
            btnRefreshIn.UseVisualStyleBackColor = true;
            // 
            // btnSearchIn
            // 
            btnSearchIn.Location = new Point(373, 46);
            btnSearchIn.Name = "btnSearchIn";
            btnSearchIn.Size = new Size(82, 26);
            btnSearchIn.TabIndex = 18;
            btnSearchIn.Text = "Cauta";
            btnSearchIn.UseVisualStyleBackColor = true;
            // 
            // FormInregistrari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdaugaIn);
            Controls.Add(btnDeleteIn);
            Controls.Add(btnModificaIn);
            Controls.Add(txtDataFinish);
            Controls.Add(txtDataStart);
            Controls.Add(txtIdAbonament);
            Controls.Add(txtIdClient);
            Controls.Add(txtSearchIn);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(dgvInregistrari);
            Controls.Add(btnRefreshIn);
            Controls.Add(btnSearchIn);
            Name = "FormInregistrari";
            Text = "FormInregistrari";
            Load += FormInregistrari_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInregistrari).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdaugaIn;
        private Button btnDeleteIn;
        private Button btnModificaIn;
        private TextBox txtDataFinish;
        private TextBox txtDataStart;
        private TextBox txtIdAbonament;
        private TextBox txtIdClient;
        private TextBox txtSearchIn;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dgvInregistrari;
        private Button btnRefreshIn;
        private Button btnSearchIn;
    }
}