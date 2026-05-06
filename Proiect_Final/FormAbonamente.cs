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

        private void btnRedMainAb_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain Main = new FormMain(); 
            Main.Show();
        }
        private void FormAbonamente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
