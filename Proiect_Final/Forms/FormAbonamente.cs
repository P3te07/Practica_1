using Proiect_Final.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Proiect_Final
{
    public partial class FormAbonamente : Form
    {
        public int selectedAbonamentId = 0;
        int nextId = Convert.ToInt32(new DbHelper().GetScalar("SELECT ISNULL(MAX(IdAbonament), 0) + 1 FROM Abonamente"));

        public FormAbonamente()
        {
            InitializeComponent();
        }

        private void FormAbonamente_Load(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            dgvAbonamente.DataSource = db.GetData("SELECT * FROM Abonamente");
        }
        private void dgvAbonamente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAbonamente.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow selectedRowAb = dgvAbonamente.SelectedRows[0];
            txtTipAb.Text = selectedRowAb.Cells["Tip"].Value?.ToString() ?? "";
            txtPretAb.Text = selectedRowAb.Cells["Pret"].Value?.ToString() ?? "";
            txtGradAb.Text = selectedRowAb.Cells["GradAcces"].Value?.ToString() ?? "";
        }

        private void FormAbonamente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<FormMain>().FirstOrDefault()?.Show();
        }

        private void dgvAbonamente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvAbonamente.Rows[e.RowIndex];

            txtTipAb.Text = row.Cells["Tip"].Value?.ToString() ?? "";
            txtPretAb.Text = row.Cells["Pret"].Value?.ToString() ?? "";
            txtGradAb.Text = row.Cells["GradAcces"].Value?.ToString() ?? "";

            selectedAbonamentId = Convert.ToInt32(row.Cells["IdAbonament"].Value);
        }

        private void btnAdaugaAb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipAb.Text) || string.IsNullOrWhiteSpace(txtPretAb.Text) || string.IsNullOrWhiteSpace(txtGradAb.Text))
            {
                MessageBox.Show("Toate câmpurile trebuie completate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (decimal.Parse(txtPretAb.Text) == 0)
            {
                MessageBox.Show("Prețul nu poate fi zero!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DbHelper db = new DbHelper();
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@IdAbonament", nextId),
                new SqlParameter("@Tip", txtTipAb.Text.Trim()),
                new SqlParameter("@Pret", decimal.Parse(txtPretAb.Text.Trim())),
                new SqlParameter("@GradAcces", txtGradAb.Text.Trim())
                };
                db.Execute("INSERT INTO Abonamente (IdAbonament, Tip, Pret, GradAcces) VALUES (@IdAbonament, @Tip, @Pret, @GradAcces)", parameters);
                dgvAbonamente.DataSource = db.GetData("SELECT * FROM Abonamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugarea abonamentului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStergeAb_Click(object sender, EventArgs e)
        {
            if (dgvAbonamente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectați un abonament pentru ștergere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idToDelete = Convert.ToInt32(dgvAbonamente.SelectedRows[0].Cells["IdAbonament"].Value);
            DbHelper db = new DbHelper();
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@IdAbonament", idToDelete)
                };
                DialogResult result = MessageBox.Show("Sunteți sigur că doriți să ștergeți acest abonament?", "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    db.Execute("DELETE FROM Abonamente WHERE IdAbonament = @IdAbonament", parameters);
                    dgvAbonamente.DataSource = db.GetData("SELECT * FROM Abonamente");
                    MessageBox.Show("Stergerea a fost executata cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ștergerea a fost anulată.", "Anulat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergerea abonamentului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModificaAb_Click(object sender, EventArgs e)
        {
            if (selectedAbonamentId == 0)
            {
                MessageBox.Show("Selectati un abonament pentru a-l modifica", "Error", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTipAb.Text))
            {
                MessageBox.Show("Tipul abonamentului trebuie specificat", "Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGradAb.Text))
            {
                MessageBox.Show("Gradul de acces trebuie specificat", "Error");
                return;
            }
            if(string.IsNullOrWhiteSpace(txtPretAb.Text) || decimal.Parse(txtPretAb.Text) < 0)
            {
                MessageBox.Show("Pretul nu poate lipsi sau fi negativ", "Error");
                return;
            }
            try
            {
                DbHelper db = new DbHelper();
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@IdAbonament", selectedAbonamentId),
                    new SqlParameter("@Tip", txtTipAb.Text.Trim()),
                    new SqlParameter("@Pret", decimal.Parse(txtPretAb.Text.Trim())),
                    new SqlParameter("@GradAcces", txtGradAb.Text.Trim())};

                db.Execute("UPDATE Abonamente SET Tip = @Tip, Pret = @Pret, GradAcces = @GradAcces WHERE IdAbonament = @IdAbonament", parameters);
                dgvAbonamente.DataSource = db.GetData("SELECT * FROM Abonamente");
                MessageBox.Show("Datele au fost modificate cu succes", "Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("A aparut o eroare la modificarea datelor", ex.Message);
            }
        }
    }
}
