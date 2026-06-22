using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tugas_Besar_CLO4.Services;
using Tugas_Besar_CLO4.Entities;

namespace Tugas_Besar_CLO4.Forms
{
    public partial class FormRiwayatBooking : Form
    {
        public FormRiwayatBooking()
        {
            InitializeComponent();
            LoadRiwayatData();
        }

        private void LoadRiwayatData()
        {
            dgvBooking.Rows.Clear();
            List<Booking> semuaRiwayat = BookingService.Instance.GetSemuaRiwayat();

            foreach (Booking b in semuaRiwayat)
            {
                dgvBooking.Rows.Add(b.NamaPemesan, b.TipeLapangan, b.Durasi);
            }
        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}