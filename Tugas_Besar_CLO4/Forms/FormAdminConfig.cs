using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tugas_Besar_CLO4.Forms
{
    public partial class FormAdminConfig : Form
    {
        public FormAdminConfig()
        {

            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Konfigurasi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormAdminConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
