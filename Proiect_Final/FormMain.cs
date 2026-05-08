using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect_Final
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnMenuClienti_Click(object sender, EventArgs e)
        {
            FormClienti Clienti = new FormClienti();
            Clienti.Show();
        }

        private void btnMenuAbonamente_Click(object sender, EventArgs e)
        {
            FormAbonamente Abonamente = new FormAbonamente();
            Abonamente.Show();
        }

        private void btnMenuInregistrari_Click(object sender, EventArgs e)
        {
            FormInregistrari Inregistrari = new FormInregistrari();
            Inregistrari.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
