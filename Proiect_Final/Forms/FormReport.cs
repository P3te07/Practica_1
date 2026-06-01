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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void btnRefreshRepo_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            try
            {
                DbHelper db = new DbHelper();
                string query = @"SELECT c.NumePrenume, 
                                COUNT(i.Id) AS NrInscrieri,
                                SUM(a.Pret) AS TotalAchitat
                                FROM InregistrareAbonament i
                                JOIN Clienti c ON c.IdClient = i.IdClient
                                JOIN Abonamente a ON a.IdAbonament = i.IdAbonament
                                GROUP BY c.NumePrenume
                                ORDER BY TotalAchitat DESC";

                dgvReport.DataSource = db.GetData(query);
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormRaport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<FormMain>().FirstOrDefault()?.Show();
        }
    }


}
