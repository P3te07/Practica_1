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
        public int selectedClientId = 0;
        public int selectedAbonamentId = 0;
        public FormInregistrari()
        {
            InitializeComponent();
        }

        private void FormInregistrari_Load(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            dgvInregistrari.DataSource = db.GetData("SELECT i.Id, i.IdClient, i.IdAbonament, c.NumePrenume, a.Tip, a.Pret, i.DataStart, i.DataFinish FROM InregistrareAbonament i JOIN Clienti c ON c.IdClient = i.IdClient JOIN Abonamente a ON a.IdAbonament = i.IdAbonament");
            dgvInregistrari.Columns["Id"].Visible = false;
            dgvInregistrari.Columns["IdClient"].Visible = false;
            dgvInregistrari.Columns["IdAbonament"].Visible = false;

        }

        private void btnRefreshIn_Click(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            dgvInregistrari.DataSource = db.GetData("SELECT i.Id, i.IdClient, i.IdAbonament, c.NumePrenume, a.Tip, a.Pret, i.DataStart, i.DataFinish FROM InregistrareAbonament i JOIN Clienti c ON c.IdClient = i.IdClient JOIN Abonamente a ON a.IdAbonament = i.IdAbonament");
            dgvInregistrari.Columns["Id"].Visible = false;
            dgvInregistrari.Columns["IdClient"].Visible = false;
            dgvInregistrari.Columns["IdAbonament"].Visible = false;
        }

        private void btnCautaIn_Click(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            string search = txtSearchIn.Text.Trim();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Search", "%" + search + "%")
            };
            dgvInregistrari.DataSource = db.GetData("SELECT i.Id, c.NumePrenume, a.Tip, a.Pret, i.DataStart, i.DataFinish FROM InregistrareAbonament i JOIN Clienti c ON c.IdClient = i.IdClient JOIN Abonamente a ON a.IdAbonament = i.IdAbonament WHERE c.NumePrenume LIKE @search OR a.Tip");
            dgvInregistrari.Columns["Id"].Visible = false;
            dgvInregistrari.Columns["IdClient"].Visible = false;
            dgvInregistrari.Columns["IdAbonament"].Visible = false;
        }

        private void FormInregistrari_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<FormMain>().FirstOrDefault()?.Show();
        }

        private void dgvInregistrari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow selectedRow = dgvInregistrari.Rows[e.RowIndex];

            txtNumePrenumeIn.Text = selectedRow.Cells["NumePrenume"].Value?.ToString() ?? "";
            txtTipAbonamentIn.Text = selectedRow.Cells["Tip"].Value?.ToString() ?? "";
            txtPretAbonamentIn.Text = selectedRow.Cells["Pret"].Value?.ToString() ?? "";
            txtDataStart.Text = selectedRow.Cells["DataStart"].Value?.ToString() ?? "";
            txtDataFinish.Text = selectedRow.Cells["DataFinish"].Value?.ToString() ?? "";
            selectedInregistrareId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            selectedClientId = Convert.ToInt32(selectedRow.Cells["IdClient"].Value);
            selectedAbonamentId = Convert.ToInt32(selectedRow.Cells["IdAbonament"].Value);
        }

        private void btnAdaugaIn_Click(object sender, EventArgs e)
        {
            
            DbHelper db = new DbHelper();
            int nextId = Convert.ToInt32(db.GetScalar("SELECT ISNULL(MAX(Id), 0) + 1 FROM InregistrareAbonament"));
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", nextId),
                new SqlParameter("@IdClient", (int)numericIdClient.Value),
                new SqlParameter("@IdAbonament", (int)numericIdAbonament.Value),
                new SqlParameter("@DataStart", txtDataStart.Text.Trim()),
                new SqlParameter("@DataFinish", txtDataFinish.Text.Trim())
            };

            db.Execute("INSERT INTO InregistrareAbonament (Id, IdClient, IdAbonament, DataStart, DataFinish) VALUES (@Id, @IdClient, @IdAbonament, @DataStart, @DataFinish)", parameters);
            dgvInregistrari.DataSource = db.GetData("SELECT i.Id, c.NumePrenume, a.Tip, a.Pret, i.DataStart, i.DataFinish FROM InregistrareAbonament i JOIN Clienti c ON c.IdClient = i.IdClient JOIN Abonamente a ON a.IdAbonament = i.IdAbonament");
            dgvInregistrari.Columns["Id"].Visible = false;
            dgvInregistrari.Columns["IdClient"].Visible = false;
            dgvInregistrari.Columns["IdAbonament"].Visible = false;
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
                    dgvInregistrari.DataSource = db.GetData("SELECT i.Id, c.NumePrenume, a.Tip, a.Pret, i.DataStart, i.DataFinish FROM InregistrareAbonament i JOIN Clienti c ON c.IdClient = i.IdClient JOIN Abonamente a ON a.IdAbonament = i.IdAbonament");
                    dgvInregistrari.Columns["Id"].Visible = false;
                    dgvInregistrari.Columns["IdClient"].Visible = false;
                    dgvInregistrari.Columns["IdAbonament"].Visible = false;
                    MessageBox.Show("Înregistrarea a fost ștearsă cu succes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare la ștergerea înregistrării. Asigurați-vă că nu există dependențe care împiedică ștergerea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateIn_Click(object sender, EventArgs e)
        {
            if (selectedInregistrareId == 0)
            {
                MessageBox.Show("Selectați o înregistrare pentru a o actualiza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DbHelper db = new DbHelper();
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@Id", selectedInregistrareId),
                new SqlParameter("@IdClient", (int)numericIdClient.Value),
                new SqlParameter("@IdAbonament", (int)numericIdAbonament.Value),
                new SqlParameter("@DataStart", txtDataStart.Text.Trim()),
                new SqlParameter("@DataFinish", txtDataFinish.Text.Trim())
                };
                db.Execute("UPDATE InregistrareAbonament SET IdClient = @IdClient, IdAbonament = @IdAbonament, DataStart = @DataStart, DataFinish = @DataFinish WHERE Id = @Id", parameters);
                dgvInregistrari.DataSource = db.GetData("SELECT i.Id, c.NumePrenume, a.Tip, a.Pret, i.DataStart, i.DataFinish FROM InregistrareAbonament i JOIN Clienti c ON c.IdClient = i.IdClient JOIN Abonamente a ON a.IdAbonament = i.IdAbonament");
                dgvInregistrari.Columns["Id"].Visible = false;
                dgvInregistrari.Columns["IdClient"].Visible = false;
                dgvInregistrari.Columns["IdAbonament"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la actualizarea înregistrării. Asigurați-vă că toate câmpurile sunt completate corect și că nu există dependențe care împiedică actualizarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
