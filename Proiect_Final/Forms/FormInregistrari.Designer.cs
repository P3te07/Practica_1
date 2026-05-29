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
            txtTipAbonamentIn = new TextBox();
            txtNumePrenumeIn = new TextBox();
            txtSearchIn = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dgvInregistrari = new DataGridView();
            btnRefreshIn = new Button();
            btnSearchIn = new Button();
            label1 = new Label();
            txtPretAbonamentIn = new TextBox();
            numericIdClient = new NumericUpDown();
            numericIdAbonament = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInregistrari).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIdClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIdAbonament).BeginInit();
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
            btnAdaugaIn.Click += btnAdaugaIn_Click;
            // 
            // btnDeleteIn
            // 
            btnDeleteIn.Location = new Point(650, 398);
            btnDeleteIn.Name = "btnDeleteIn";
            btnDeleteIn.Size = new Size(82, 26);
            btnDeleteIn.TabIndex = 30;
            btnDeleteIn.Text = "Sterge";
            btnDeleteIn.UseVisualStyleBackColor = true;
            btnDeleteIn.Click += btnDeleteIn_Click;
            // 
            // btnModificaIn
            // 
            btnModificaIn.Location = new Point(650, 355);
            btnModificaIn.Name = "btnModificaIn";
            btnModificaIn.Size = new Size(82, 26);
            btnModificaIn.TabIndex = 29;
            btnModificaIn.Text = "Modifica";
            btnModificaIn.UseVisualStyleBackColor = true;
            btnModificaIn.Click += btnUpdateIn_Click;
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
            // txtTipAbonamentIn
            // 
            txtTipAbonamentIn.Location = new Point(136, 381);
            txtTipAbonamentIn.Name = "txtTipAbonamentIn";
            txtTipAbonamentIn.Size = new Size(145, 23);
            txtTipAbonamentIn.TabIndex = 23;
            // 
            // txtNumePrenumeIn
            // 
            txtNumePrenumeIn.Location = new Point(136, 329);
            txtNumePrenumeIn.Name = "txtNumePrenumeIn";
            txtNumePrenumeIn.Size = new Size(145, 23);
            txtNumePrenumeIn.TabIndex = 21;
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
            label11.Size = new Size(90, 15);
            label11.TabIndex = 24;
            label11.Text = "Tip Abonament";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 335);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 22;
            label12.Text = "NumePrenume";
            // 
            // dgvInregistrari
            // 
            dgvInregistrari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInregistrari.Location = new Point(16, 90);
            dgvInregistrari.Name = "dgvInregistrari";
            dgvInregistrari.Size = new Size(735, 211);
            dgvInregistrari.TabIndex = 20;
            dgvInregistrari.CellClick += dgvInregistrari_CellClick;
            // 
            // btnRefreshIn
            // 
            btnRefreshIn.Location = new Point(535, 46);
            btnRefreshIn.Name = "btnRefreshIn";
            btnRefreshIn.Size = new Size(82, 26);
            btnRefreshIn.TabIndex = 19;
            btnRefreshIn.Text = "Refresh";
            btnRefreshIn.UseVisualStyleBackColor = true;
            btnRefreshIn.Click += btnRefreshIn_Click;
            // 
            // btnSearchIn
            // 
            btnSearchIn.Location = new Point(373, 46);
            btnSearchIn.Name = "btnSearchIn";
            btnSearchIn.Size = new Size(82, 26);
            btnSearchIn.TabIndex = 18;
            btnSearchIn.Text = "Cauta";
            btnSearchIn.UseVisualStyleBackColor = true;
            btnSearchIn.Click += btnCautaIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 426);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 32;
            label1.Text = "Pret";
            // 
            // txtPretAbonamentIn
            // 
            txtPretAbonamentIn.Location = new Point(136, 423);
            txtPretAbonamentIn.Name = "txtPretAbonamentIn";
            txtPretAbonamentIn.Size = new Size(145, 23);
            txtPretAbonamentIn.TabIndex = 33;
            // 
            // numericIdClient
            // 
            numericIdClient.Location = new Point(392, 418);
            numericIdClient.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericIdClient.Name = "numericIdClient";
            numericIdClient.Size = new Size(46, 23);
            numericIdClient.TabIndex = 34;
            numericIdClient.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericIdAbonament
            // 
            numericIdAbonament.Location = new Point(548, 418);
            numericIdAbonament.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericIdAbonament.Name = "numericIdAbonament";
            numericIdAbonament.Size = new Size(46, 23);
            numericIdAbonament.TabIndex = 35;
            numericIdAbonament.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 423);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 36;
            label2.Text = "IdClient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 423);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 37;
            label3.Text = "IdAbonament";
            // 
            // FormInregistrari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericIdAbonament);
            Controls.Add(numericIdClient);
            Controls.Add(txtPretAbonamentIn);
            Controls.Add(label1);
            Controls.Add(btnAdaugaIn);
            Controls.Add(btnDeleteIn);
            Controls.Add(btnModificaIn);
            Controls.Add(txtDataFinish);
            Controls.Add(txtDataStart);
            Controls.Add(txtTipAbonamentIn);
            Controls.Add(txtNumePrenumeIn);
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
            ((System.ComponentModel.ISupportInitialize)numericIdClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericIdAbonament).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdaugaIn;
        private Button btnDeleteIn;
        private Button btnModificaIn;
        private TextBox txtDataFinish;
        private TextBox txtDataStart;
        private TextBox txtTipAbonamentIn;
        private TextBox txtNumePrenumeIn;
        private TextBox txtSearchIn;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dgvInregistrari;
        private Button btnRefreshIn;
        private Button btnSearchIn;
        private Label label1;
        private TextBox txtPretAbonamentIn;
        private NumericUpDown numericIdClient;
        private NumericUpDown numericIdAbonament;
        private Label label2;
        private Label label3;
    }
}