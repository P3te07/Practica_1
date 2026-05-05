using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;


using Proiect_Final.Data;

namespace Proiect_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DbHelper db = new DbHelper();
            string sql = "SELECT * FROM [dbo].[Clienti]";
            dgvClienti.DataSource = db.Execute(sql);
        }

        private void btnCautaCl_click(object sender, EventArgs e)
        {

        }
    }
}
