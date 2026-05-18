using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System;
using Proiect_Final.Data;
using System.Drawing.Text;

namespace Proiect_Final
{
    public partial class FormClienti : Form
    {
        private int selectedClientId = 0;
        public FormClienti()
        {
            InitializeComponent();
        }

        private void btnCautaCl_click(object sender, EventArgs e)
        {

        }

        private void FormClienti_Load(object sender, EventArgs e)
        {

            DbHelper db = new DbHelper();
            dgvClienti.DataSource = db.GetData("SELECT * FROM Clienti");

        }

        private void FormClienti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<FormMain>().FirstOrDefault()?.Show();
        }

        private void dgvClienti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow selectedRow = dgvClienti.SelectedRows[0];
            txtNumePrenume.Text = selectedRow.Cells["NumePrenume"].Value.ToString();
            txtTelefonCl.Text = selectedRow.Cells["Telefon"].Value.ToString();
            txtDataNasterii.Text = selectedRow.Cells["DataNasterii"].Value.ToString();
            txtEmailCl.Text = selectedRow.Cells["Email"].Value.ToString();
            selectedClientId = Convert.ToInt32(selectedRow.Cells["IdClient"].Value);
        }

        private void btnAdaugaCl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumePrenume.Text) || string.IsNullOrWhiteSpace(txtEmailCl.Text) || string.IsNullOrWhiteSpace(txtDataNasterii.Text) || string.IsNullOrWhiteSpace(txtTelefonCl.Text))
            {
                MessageBox.Show("Toate câmpurile trebuie completate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtEmailCl.Text.Contains("@"))
            {
                MessageBox.Show("Adresa de email nu este validă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTelefonCl.Text.Length != 10)
            {
                MessageBox.Show("Numărul de telefon trebuie să aibă 10 cifre!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DbHelper db = new DbHelper();
            int nextId = Convert.ToInt32(db.GetScalar("SELECT ISNULL(MAX(IdClient), 0) + 1 FROM Clienti"));

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdClient", nextId),
                new SqlParameter("@NumePrenume", txtNumePrenume.Text),
                new SqlParameter("@Telefon", txtTelefonCl.Text),
                new SqlParameter("@DataNasterii", DateTime.Parse(txtDataNasterii.Text)),
                new SqlParameter("@Email", txtEmailCl.Text)
            };

            db.Execute("INSERT INTO Clienti (IdClient, NumePrenume, Telefon, DataNasterii, Email) VALUES (@IdClient, @NumePrenume, @Telefon, @DataNasterii, @Email)", parameters);

            dgvClienti.DataSource = db.GetData("SELECT * FROM Clienti");
        }

        private void btnDeleteCl_Click(object sender, EventArgs e)
        {
            if (selectedClientId == 0)
            {
                MessageBox.Show("Selectați un client pentru a șterge!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Sunteți sigur că doriți să ștergeți acest client?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DbHelper db = new DbHelper();
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@IdClient", selectedClientId)
                    };
                    db.Execute("DELETE FROM Clienti WHERE IdClient = @IdClient", parameters);
                    dgvClienti.DataSource = db.GetData("SELECT * FROM Clienti");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la ștergerea clientului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateCl_Click(object sender, EventArgs e)
        {
            if (selectedClientId == 0)
            {
                MessageBox.Show("Selectați un client pentru a actualiza!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNumePrenume.Text) || string.IsNullOrWhiteSpace(txtEmailCl.Text) || string.IsNullOrWhiteSpace(txtDataNasterii.Text) || string.IsNullOrWhiteSpace(txtTelefonCl.Text))
            {
                MessageBox.Show("Toate câmpurile trebuie completate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtEmailCl.Text.Contains("@"))
            {
                MessageBox.Show("Adresa de email nu este validă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTelefonCl.Text.Length != 10)
            {
                MessageBox.Show("Numărul de telefon trebuie să aibă 10 cifre!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DbHelper db = new DbHelper();
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IdClient", selectedClientId),
                    new SqlParameter("@NumePrenume", txtNumePrenume.Text),
                    new SqlParameter("@Telefon", txtTelefonCl.Text),
                    new SqlParameter("@DataNasterii", DateTime.Parse(txtDataNasterii.Text)),
                    new SqlParameter("@Email", txtEmailCl.Text)
                };
                db.Execute("UPDATE Clienti SET NumePrenume = @NumePrenume, Telefon = @Telefon, DataNasterii = @DataNasterii, Email = @Email WHERE IdClient = @IdClient", parameters);
                dgvClienti.DataSource = db.GetData("SELECT * FROM Clienti");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la actualizarea clientului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
