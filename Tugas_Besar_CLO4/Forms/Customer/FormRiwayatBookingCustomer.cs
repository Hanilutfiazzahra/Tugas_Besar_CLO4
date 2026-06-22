using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tugas_Besar_CLO4.Services;
using Tugas_Besar_CLO4.Entities;

namespace Tugas_Besar_CLO4.Forms.Customer
{
    public partial class FormRiwayatBookingCustomer : Form
    {
        private string identitasCustomer;

        public FormRiwayatBookingCustomer(string customerId)
        {
            InitializeComponent();
            identitasCustomer = customerId;
            LoadRiwayatData();
        }

        private void LoadRiwayatData()
        {
            dgvBooking.Rows.Clear();

            // 1. Tarik data dari Service
            List<Booking> riwayatSaya = BookingService.Instance.GetRiwayatCustomer(identitasCustomer);

            // 2. DEBUG: Tambahkan ini untuk memastikan apakah datanya memang nol
            if (riwayatSaya.Count == 0)
            {
                MessageBox.Show("Tidak ada riwayat ditemukan untuk: " + identitasCustomer +
                                "\nPastikan nama pemesan saat booking sama persis dengan email login ini.",
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 3. Masukkan data ke dalam baris tabel jika ada
                foreach (Booking b in riwayatSaya)
                {
                    dgvBooking.Rows.Add(b.NamaPemesan, b.TipeLapangan, b.Durasi, b.Status.ToString());
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}