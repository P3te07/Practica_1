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
        public FormClienti()
        {
            InitializeComponent();
        }

        private void btnCautaCl_click(object sender, EventArgs e)
        {

        }

        private void FormClienti_Load(object sender, EventArgs e)
        {
            try
            {
                DbHelper db = new DbHelper();
                dgvClienti.DataSource = db.GetData("SELECT * FROM Clienti");
                MessageBox.Show("Datele au fost încărcate cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormClienti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<FormMain>().FirstOrDefault()?.Show();
        }

    }
}
