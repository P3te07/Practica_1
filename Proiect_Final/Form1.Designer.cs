namespace Proiect_Final
{
    partial class Form1
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
            tabPage2 = new TabPage();
            btnSearchIn = new Button();
            btnRefreshIn = new Button();
            dgvInregistrari = new DataGridView();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtSearchIn = new TextBox();
            txtIdClient = new TextBox();
            txtIdAbonament = new TextBox();
            txtDataStart = new TextBox();
            txtDataFinish = new TextBox();
            btnModificaIn = new Button();
            btnDeleteIn = new Button();
            tabPage1 = new TabPage();
            btnSearchAb = new Button();
            btnRefreshAb = new Button();
            dgvAbonamente = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtSearchAb = new TextBox();
            txtTipAb = new TextBox();
            txtPretAb = new TextBox();
            txtGradAb = new TextBox();
            btnModificaAb = new Button();
            btnDeleteAb = new Button();
            tabPageClienti = new TabPage();
            btnCautaCl = new Button();
            btnRefreshCl = new Button();
            dgvClienti = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSearch = new TextBox();
            txtNumePrenume = new TextBox();
            txtDataNasterii = new TextBox();
            txtTelefonCl = new TextBox();
            txtEmailCl = new TextBox();
            btnModificaCl = new Button();
            btnDeleteCl = new Button();
            tabControlMain = new TabControl();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInregistrari).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAbonamente).BeginInit();
            tabPageClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClienti).BeginInit();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteIn);
            tabPage2.Controls.Add(btnModificaIn);
            tabPage2.Controls.Add(txtDataFinish);
            tabPage2.Controls.Add(txtDataStart);
            tabPage2.Controls.Add(txtIdAbonament);
            tabPage2.Controls.Add(txtIdClient);
            tabPage2.Controls.Add(txtSearchIn);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(dgvInregistrari);
            tabPage2.Controls.Add(btnRefreshIn);
            tabPage2.Controls.Add(btnSearchIn);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 419);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Inregistrari";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearchIn
            // 
            btnSearchIn.Location = new Point(377, 19);
            btnSearchIn.Name = "btnSearchIn";
            btnSearchIn.Size = new Size(82, 26);
            btnSearchIn.TabIndex = 1;
            btnSearchIn.Text = "Cauta";
            btnSearchIn.UseVisualStyleBackColor = true;
            // 
            // btnRefreshIn
            // 
            btnRefreshIn.Location = new Point(539, 19);
            btnRefreshIn.Name = "btnRefreshIn";
            btnRefreshIn.Size = new Size(82, 26);
            btnRefreshIn.TabIndex = 2;
            btnRefreshIn.Text = "Refresh";
            btnRefreshIn.UseVisualStyleBackColor = true;
            // 
            // dgvInregistrari
            // 
            dgvInregistrari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInregistrari.Location = new Point(20, 63);
            dgvInregistrari.Name = "dgvInregistrari";
            dgvInregistrari.Size = new Size(735, 211);
            dgvInregistrari.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 308);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 5;
            label12.Text = "Id Client";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 360);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 7;
            label11.Text = "Id Abonament";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(358, 308);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 9;
            label10.Text = "Data Start";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(358, 360);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 10;
            label9.Text = "Data Finish";
            // 
            // txtSearchIn
            // 
            txtSearchIn.Location = new Point(20, 19);
            txtSearchIn.Name = "txtSearchIn";
            txtSearchIn.Size = new Size(332, 23);
            txtSearchIn.TabIndex = 0;
            // 
            // txtIdClient
            // 
            txtIdClient.Location = new Point(140, 302);
            txtIdClient.Name = "txtIdClient";
            txtIdClient.Size = new Size(145, 23);
            txtIdClient.TabIndex = 4;
            // 
            // txtIdAbonament
            // 
            txtIdAbonament.Location = new Point(140, 354);
            txtIdAbonament.Name = "txtIdAbonament";
            txtIdAbonament.Size = new Size(145, 23);
            txtIdAbonament.TabIndex = 6;
            // 
            // txtDataStart
            // 
            txtDataStart.Location = new Point(453, 302);
            txtDataStart.Name = "txtDataStart";
            txtDataStart.Size = new Size(145, 23);
            txtDataStart.TabIndex = 8;
            // 
            // txtDataFinish
            // 
            txtDataFinish.Location = new Point(453, 354);
            txtDataFinish.Name = "txtDataFinish";
            txtDataFinish.Size = new Size(145, 23);
            txtDataFinish.TabIndex = 11;
            // 
            // btnModificaIn
            // 
            btnModificaIn.Location = new Point(654, 299);
            btnModificaIn.Name = "btnModificaIn";
            btnModificaIn.Size = new Size(82, 26);
            btnModificaIn.TabIndex = 12;
            btnModificaIn.Text = "Modifica";
            btnModificaIn.UseVisualStyleBackColor = true;
            // 
            // btnDeleteIn
            // 
            btnDeleteIn.Location = new Point(654, 346);
            btnDeleteIn.Name = "btnDeleteIn";
            btnDeleteIn.Size = new Size(82, 26);
            btnDeleteIn.TabIndex = 13;
            btnDeleteIn.Text = "Sterge";
            btnDeleteIn.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeleteAb);
            tabPage1.Controls.Add(btnModificaAb);
            tabPage1.Controls.Add(txtGradAb);
            tabPage1.Controls.Add(txtPretAb);
            tabPage1.Controls.Add(txtTipAb);
            tabPage1.Controls.Add(txtSearchAb);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(dgvAbonamente);
            tabPage1.Controls.Add(btnRefreshAb);
            tabPage1.Controls.Add(btnSearchAb);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 419);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Abonamente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearchAb
            // 
            btnSearchAb.Location = new Point(377, 19);
            btnSearchAb.Name = "btnSearchAb";
            btnSearchAb.Size = new Size(82, 26);
            btnSearchAb.TabIndex = 1;
            btnSearchAb.Text = "Cauta";
            btnSearchAb.UseVisualStyleBackColor = true;
            // 
            // btnRefreshAb
            // 
            btnRefreshAb.Location = new Point(539, 19);
            btnRefreshAb.Name = "btnRefreshAb";
            btnRefreshAb.Size = new Size(82, 26);
            btnRefreshAb.TabIndex = 2;
            btnRefreshAb.Text = "Refresh";
            btnRefreshAb.UseVisualStyleBackColor = true;
            // 
            // dgvAbonamente
            // 
            dgvAbonamente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAbonamente.Location = new Point(20, 63);
            dgvAbonamente.Name = "dgvAbonamente";
            dgvAbonamente.Size = new Size(735, 211);
            dgvAbonamente.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 308);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 5;
            label8.Text = "Tip";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 360);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 7;
            label7.Text = "Pret";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 308);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 9;
            label6.Text = "Grad Acces";
            // 
            // txtSearchAb
            // 
            txtSearchAb.Location = new Point(20, 19);
            txtSearchAb.Name = "txtSearchAb";
            txtSearchAb.Size = new Size(332, 23);
            txtSearchAb.TabIndex = 0;
            // 
            // txtTipAb
            // 
            txtTipAb.Location = new Point(140, 302);
            txtTipAb.Name = "txtTipAb";
            txtTipAb.Size = new Size(145, 23);
            txtTipAb.TabIndex = 4;
            // 
            // txtPretAb
            // 
            txtPretAb.Location = new Point(140, 354);
            txtPretAb.Name = "txtPretAb";
            txtPretAb.Size = new Size(145, 23);
            txtPretAb.TabIndex = 6;
            // 
            // txtGradAb
            // 
            txtGradAb.Location = new Point(430, 302);
            txtGradAb.Name = "txtGradAb";
            txtGradAb.Size = new Size(145, 23);
            txtGradAb.TabIndex = 8;
            // 
            // btnModificaAb
            // 
            btnModificaAb.Location = new Point(654, 299);
            btnModificaAb.Name = "btnModificaAb";
            btnModificaAb.Size = new Size(82, 26);
            btnModificaAb.TabIndex = 12;
            btnModificaAb.Text = "Modifica";
            btnModificaAb.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAb
            // 
            btnDeleteAb.Location = new Point(654, 346);
            btnDeleteAb.Name = "btnDeleteAb";
            btnDeleteAb.Size = new Size(82, 26);
            btnDeleteAb.TabIndex = 13;
            btnDeleteAb.Text = "Sterge";
            btnDeleteAb.UseVisualStyleBackColor = true;
            // 
            // tabPageClienti
            // 
            tabPageClienti.Controls.Add(btnDeleteCl);
            tabPageClienti.Controls.Add(btnModificaCl);
            tabPageClienti.Controls.Add(txtEmailCl);
            tabPageClienti.Controls.Add(txtTelefonCl);
            tabPageClienti.Controls.Add(txtDataNasterii);
            tabPageClienti.Controls.Add(txtNumePrenume);
            tabPageClienti.Controls.Add(txtSearch);
            tabPageClienti.Controls.Add(label4);
            tabPageClienti.Controls.Add(label3);
            tabPageClienti.Controls.Add(label2);
            tabPageClienti.Controls.Add(label1);
            tabPageClienti.Controls.Add(dgvClienti);
            tabPageClienti.Controls.Add(btnRefreshCl);
            tabPageClienti.Controls.Add(btnCautaCl);
            tabPageClienti.Location = new Point(4, 24);
            tabPageClienti.Name = "tabPageClienti";
            tabPageClienti.Padding = new Padding(3);
            tabPageClienti.Size = new Size(789, 419);
            tabPageClienti.TabIndex = 0;
            tabPageClienti.Text = "Clienti";
            tabPageClienti.UseVisualStyleBackColor = true;
            // 
            // btnCautaCl
            // 
            btnCautaCl.Location = new Point(377, 19);
            btnCautaCl.Name = "btnCautaCl";
            btnCautaCl.Size = new Size(82, 26);
            btnCautaCl.TabIndex = 1;
            btnCautaCl.Text = "Cauta";
            btnCautaCl.UseVisualStyleBackColor = true;
            // 
            // btnRefreshCl
            // 
            btnRefreshCl.Location = new Point(539, 19);
            btnRefreshCl.Name = "btnRefreshCl";
            btnRefreshCl.Size = new Size(82, 26);
            btnRefreshCl.TabIndex = 2;
            btnRefreshCl.Text = "Refresh";
            btnRefreshCl.UseVisualStyleBackColor = true;
            // 
            // dgvClienti
            // 
            dgvClienti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClienti.Location = new Point(20, 63);
            dgvClienti.Name = "dgvClienti";
            dgvClienti.Size = new Size(735, 211);
            dgvClienti.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 305);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Nume Prenume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 357);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 7;
            label2.Text = "Data Nasterii";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 305);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 357);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(332, 23);
            txtSearch.TabIndex = 0;
            // 
            // txtNumePrenume
            // 
            txtNumePrenume.Location = new Point(140, 302);
            txtNumePrenume.Name = "txtNumePrenume";
            txtNumePrenume.Size = new Size(145, 23);
            txtNumePrenume.TabIndex = 4;
            // 
            // txtDataNasterii
            // 
            txtDataNasterii.Location = new Point(140, 354);
            txtDataNasterii.Name = "txtDataNasterii";
            txtDataNasterii.Size = new Size(145, 23);
            txtDataNasterii.TabIndex = 6;
            // 
            // txtTelefonCl
            // 
            txtTelefonCl.Location = new Point(425, 302);
            txtTelefonCl.Name = "txtTelefonCl";
            txtTelefonCl.Size = new Size(145, 23);
            txtTelefonCl.TabIndex = 8;
            // 
            // txtEmailCl
            // 
            txtEmailCl.Location = new Point(425, 354);
            txtEmailCl.Name = "txtEmailCl";
            txtEmailCl.Size = new Size(145, 23);
            txtEmailCl.TabIndex = 11;
            // 
            // btnModificaCl
            // 
            btnModificaCl.Location = new Point(654, 299);
            btnModificaCl.Name = "btnModificaCl";
            btnModificaCl.Size = new Size(82, 26);
            btnModificaCl.TabIndex = 12;
            btnModificaCl.Text = "Modifica";
            btnModificaCl.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCl
            // 
            btnDeleteCl.Location = new Point(654, 346);
            btnDeleteCl.Name = "btnDeleteCl";
            btnDeleteCl.Size = new Size(82, 26);
            btnDeleteCl.TabIndex = 13;
            btnDeleteCl.Text = "Sterge";
            btnDeleteCl.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageClienti);
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Location = new Point(2, 2);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(797, 447);
            tabControlMain.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Name = "Form1";
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInregistrari).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAbonamente).EndInit();
            tabPageClienti.ResumeLayout(false);
            tabPageClienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClienti).EndInit();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
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
        private TabPage tabPage1;
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
        private TabPage tabPageClienti;
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
        private TabControl tabControlMain;
    }
}
