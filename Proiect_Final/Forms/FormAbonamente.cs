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
        }
    }
}
