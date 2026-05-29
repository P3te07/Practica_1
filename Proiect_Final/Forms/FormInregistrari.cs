using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System;
using Proiect_Final.Data;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;


namespace Proiect_Final
{
    public partial class FormInregistrari : Form
    {
        public int selectedInregistrareId = 0;
        public FormInregistrari()
        {
            InitializeComponent();
        }

        private void FormInregistrari_Load(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            dgvInregistrari.DataSource = db.GetData("SELECT * FROM InregistrareAbonament");
        }

        private void btnRefreshIn_Click(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            dgvInregistrari.DataSource = db.GetData("SELECT * FROM InregistrareAbonament");
        }

        private void btnCautaIn_Click(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            string search = txtSearchIn.Text.Trim();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Search", "%" + search + "%")
            };
            dgvInregistrari.DataSource = db.GetData("SELECT * FROM InregistrareAbonament WHERE DataStart LIKE @search OR DataFinish LIKE @search", parameters);
        }

        private void FormInregistrari_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<FormMain>().FirstOrDefault()?.Show();
        }

        private void dgvInregistrari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInregistrari.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow selectedRow = dgvInregistrari.SelectedRows[0];

            txtIdClient.Text = selectedRow.Cells["IdClient"].Value.ToString() ?? "";
            txtIdAbonament.Text = selectedRow.Cells["IdAbonament"].Value.ToString() ?? "";
            txtDataStart.Text = selectedRow.Cells["DataStart"].Value.ToString() ?? "";
            txtDataFinish.Text = selectedRow.Cells["DataFinish"].Value.ToString() ?? "";
            selectedInregistrareId = Convert.ToInt32(selectedRow.Cells["IdInregistrare"].Value);
        }

        private void btnAdaugaIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdClient.Text))
            {
                MessageBox.Show("Id-ul clientului nu poate lipsi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtIdAbonament.Text))
            {
                MessageBox.Show("Id-ul abonamentului nu poate lipsi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DbHelper db = new DbHelper();
            int nextId = Convert.ToInt32(db.GetScalar("SELECT ISNULL(MAX(Id), 0) + 1 FROM InregistrareAbonament"));
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", nextId),
                new SqlParameter("@IdClient", txtIdClient.Text.Trim()),
                new SqlParameter("@IdAbonament", txtIdAbonament.Text.Trim()),
                new SqlParameter("@DataStart", txtDataStart.Text.Trim()),
                new SqlParameter("@DataFinish", txtDataFinish.Text.Trim())
            };

            db.Execute("INSERT INTO InregistrareAbonament (Id, IdClient, IdAbonament, DataStart, DataFinish) VALUES (@Id, @IdClient, @IdAbonament, @DataStart, @DataFinish)", parameters);
            dgvInregistrari.DataSource = db.GetData("SELECT * FROM InregistrareAbonament");
        }

        private void btnDeleteIn_Click(object sender, EventArgs e)
        {
            if (selectedInregistrareId == 0)
            {
                MessageBox.Show("Selectați o înregistrare pentru a o șterge", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DialogResult result = MessageBox.Show("Sunteți sigur că doriți să ștergeți această înregistrare?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DbHelper db = new DbHelper();

                    SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@Id", selectedInregistrareId)
                    };
                    db.Execute("DELETE FROM InregistrareAbonament WHERE Id = @Id", parameters);
                    dgvInregistrari.DataSource = db.GetData("SELECT * FROM InregistrareAbonament");
                    MessageBox.Show("Înregistrarea a fost ștearsă cu succes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("A apărut o eroare la ștergerea înregistrării. Asigurați-vă că nu există dependențe care împiedică ștergerea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
