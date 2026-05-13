namespace Proiect_Final
{
    partial class FormAbonamente
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
            btnAdaugaAb = new Button();
            btnDeleteAb = new Button();
            btnModificaAb = new Button();
            txtGradAb = new TextBox();
            txtPretAb = new TextBox();
            txtTipAb = new TextBox();
            txtSearchAb = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgvAbonamente = new DataGridView();
            btnRefreshAb = new Button();
            btnSearchAb = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAbonamente).BeginInit();
            SuspendLayout();
            // 
            // btnAdaugaAb
            // 
            btnAdaugaAb.Location = new Point(650, 306);
            btnAdaugaAb.Name = "btnAdaugaAb";
            btnAdaugaAb.Size = new Size(82, 26);
            btnAdaugaAb.TabIndex = 29;
            btnAdaugaAb.Text = "Adauga";
            btnAdaugaAb.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAb
            // 
            btnDeleteAb.Location = new Point(650, 398);
            btnDeleteAb.Name = "btnDeleteAb";
            btnDeleteAb.Size = new Size(82, 26);
            btnDeleteAb.TabIndex = 28;
            btnDeleteAb.Text = "Sterge";
            btnDeleteAb.UseVisualStyleBackColor = true;
            // 
            // btnModificaAb
            // 
            btnModificaAb.Location = new Point(650, 357);
            btnModificaAb.Name = "btnModificaAb";
            btnModificaAb.Size = new Size(82, 26);
            btnModificaAb.TabIndex = 27;
            btnModificaAb.Text = "Modifica";
            btnModificaAb.UseVisualStyleBackColor = true;
            // 
            // txtGradAb
            // 
            txtGradAb.Location = new Point(426, 328);
            txtGradAb.Name = "txtGradAb";
            txtGradAb.Size = new Size(145, 23);
            txtGradAb.TabIndex = 25;
            // 
            // txtPretAb
            // 
            txtPretAb.Location = new Point(136, 380);
            txtPretAb.Name = "txtPretAb";
            txtPretAb.Size = new Size(145, 23);
            txtPretAb.TabIndex = 23;
            // 
            // txtTipAb
            // 
            txtTipAb.Location = new Point(136, 328);
            txtTipAb.Name = "txtTipAb";
            txtTipAb.Size = new Size(145, 23);
            txtTipAb.TabIndex = 21;
            // 
            // txtSearchAb
            // 
            txtSearchAb.Location = new Point(16, 45);
            txtSearchAb.Name = "txtSearchAb";
            txtSearchAb.Size = new Size(332, 23);
            txtSearchAb.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 334);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 26;
            label6.Text = "Grad Acces";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 386);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 24;
            label7.Text = "Pret";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 334);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 22;
            label8.Text = "Tip";
            // 
            // dgvAbonamente
            // 
            dgvAbonamente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAbonamente.Location = new Point(16, 89);
            dgvAbonamente.Name = "dgvAbonamente";
            dgvAbonamente.Size = new Size(735, 211);
            dgvAbonamente.TabIndex = 20;
            dgvAbonamente.SelectionChanged += dgvAbonamente_SelectionChanged;
            // 
            // btnRefreshAb
            // 
            btnRefreshAb.Location = new Point(535, 45);
            btnRefreshAb.Name = "btnRefreshAb";
            btnRefreshAb.Size = new Size(82, 26);
            btnRefreshAb.TabIndex = 19;
            btnRefreshAb.Text = "Refresh";
            btnRefreshAb.UseVisualStyleBackColor = true;
            // 
            // btnSearchAb
            // 
            btnSearchAb.Location = new Point(373, 45);
            btnSearchAb.Name = "btnSearchAb";
            btnSearchAb.Size = new Size(82, 26);
            btnSearchAb.TabIndex = 18;
            btnSearchAb.Text = "Cauta";
            btnSearchAb.UseVisualStyleBackColor = true;
            // 
            // FormAbonamente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdaugaAb);
            Controls.Add(btnDeleteAb);
            Controls.Add(btnModificaAb);
            Controls.Add(txtGradAb);
            Controls.Add(txtPretAb);
            Controls.Add(txtTipAb);
            Controls.Add(txtSearchAb);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dgvAbonamente);
            Controls.Add(btnRefreshAb);
            Controls.Add(btnSearchAb);
            Name = "FormAbonamente";
            Text = "FormAbonamente";
            Load += FormAbonamente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAbonamente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdaugaAb;
        private Button btnDeleteAb;
        private Button btnModificaAb;
        private TextBox txtGradAb;
        private TextBox txtPretAb;
        private TextBox txtTipAb;
        private TextBox txtSearchAb;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dgvAbonamente;
        private Button btnRefreshAb;
        private Button btnSearchAb;
    }
}