using System.Data.SqlClient;
using System.Data;
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
            txtIdClientCl.Text = selectedClientId.ToString();
        }
    }
}
