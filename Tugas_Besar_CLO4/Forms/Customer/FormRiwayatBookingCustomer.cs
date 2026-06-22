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

        // Constructor menerima identitas customer (email/nama) dari halaman sebelumnya
        public FormRiwayatBookingCustomer(string customerId)
        {
            InitializeComponent();
            identitasCustomer = customerId;
            LoadRiwayatData();
        }

        private void LoadRiwayatData()
        {
            dgvBooking.Rows.Clear();

            // Tarik data spesifik untuk customer ini menggunakan Singleton
            List<Booking> riwayatSaya = BookingService.Instance.GetRiwayatCustomer(identitasCustomer);

            // Masukkan data ke dalam baris tabel
            foreach (Booking b in riwayatSaya)
            {
                dgvBooking.Rows.Add(b.NamaPemesan, b.TipeLapangan, b.Durasi, b.Status.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Menutup form riwayat dan otomatis kembali ke FormUser yang disembunyikan (Hide)
            this.Close();
        }
    }
}