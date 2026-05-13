using Proiect_Final.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect_Final
{
    public partial class FormInregistrari : Form
    {
        public FormInregistrari()
        {
            InitializeComponent();
        }

        private void FormInregistrari_Load(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            dgvInregistrari.DataSource = db.GetData("SELECT * FROM InregistrareAbonament");
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
            txtIdClient.Text = selectedRow.Cells["IdClient"].Value.ToString();
        }
    }
}
