using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tugas_Besar_CLO4.Forms
{
    public partial class FormRiwayatBooking : Form
    {
        public FormRiwayatBooking()
        {
            InitializeComponent();
        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Menutup form riwayat ini untuk kembali ke halaman sebelumnya
            this.Close();
        }
    }
}
