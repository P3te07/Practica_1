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
    public partial class FormAbonamente : Form
    {
        public FormAbonamente()
        {
            InitializeComponent();
        }
        private void FormAbonamente_Load(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            dgvAbonamente.DataSource = db.GetData("SELECT * FROM Abonamente");
        }
        private void FormAbonamente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<FormMain>().FirstOrDefault()?.Show();
        }
    }
}
