using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tugas_Besar_CLO4.Services;

namespace Tugas_Besar_CLO4.Forms.Admin
{
    public partial class FormAdmin : Form
    {
        private string emailAdmin;

        public FormAdmin(string email)
        {
            InitializeComponent();

            emailAdmin = email;
        }

        private void FormAdmin_Load(
            object sender,
            EventArgs e)
        {
            lblJudul.Text =
                "Selamat Datang, Admin";

            lblEmail.Text =
                "Email: " + emailAdmin;
        }

        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}