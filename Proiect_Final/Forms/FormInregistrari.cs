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
            dgvInregistrari.DataSource = db.GetData("SELECT * FROM InregistrareAbonament WHERE DataStart LIKE @search OR DataFinish LIKE @search",parameters);
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
    }
}
