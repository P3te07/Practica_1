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


        private void FormClienti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<FormMain>().FirstOrDefault()?.Show();
        }

    }
}
