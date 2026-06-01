namespace Proiect_Final
{
    partial class FormReport
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
            dgvReport = new DataGridView();
            label2 = new Label();
            btnRefreshRepo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(12, 48);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(776, 319);
            dgvReport.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 18);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Raport Sumar";
            // 
            // btnRefreshRepo
            // 
            btnRefreshRepo.Location = new Point(519, 14);
            btnRefreshRepo.Name = "btnRefreshRepo";
            btnRefreshRepo.Size = new Size(142, 23);
            btnRefreshRepo.TabIndex = 3;
            btnRefreshRepo.Text = "Refresh";
            btnRefreshRepo.UseVisualStyleBackColor = true;
            btnRefreshRepo.Click += btnRefreshRepo_Click;
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefreshRepo);
            Controls.Add(label2);
            Controls.Add(dgvReport);
            Name = "FormReport";
            Text = "FormReport";
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReport;
        private Label label2;
        private Button btnRefreshRepo;
    }
}