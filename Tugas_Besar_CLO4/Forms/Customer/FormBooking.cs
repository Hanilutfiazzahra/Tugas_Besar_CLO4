using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tugas_Besar_CLO4.Config;
using Tugas_Besar_CLO4.Entities;

namespace Tugas_Besar_CLO4.Forms.Customer
{
    public partial class FormBooking : Form
    {

        public FormBooking(string tipeLapangan)
        {
            InitializeComponent();

            txtLapangan.Text = tipeLapangan;

            HitungTotal();
        }
        public FormBooking(
            string tanggal,
            string gedung,
            string tipeLapangan,
            string jamMulai)
        {
            InitializeComponent();

            txtHari.Text = tanggal;
            txtGedung.Text = gedung;
            txtLapangan.Text = tipeLapangan;
            txtMulai.Text = jamMulai;

            HitungTotal();
        }
        public FormBooking()
        {
            InitializeComponent();

            lblStatus.Text = "Pending";
        }
        private void HitungTotal()
        {
            int hargaPerJam = 50000;

            // Cek apakah teks lapangan mengandung kata "VIP", "Court B", "Court D", atau "Court F"
            if (txtLapangan.Text.Contains("VIP") ||
                txtLapangan.Text == "Court B" ||
                txtLapangan.Text == "Court D" ||
                txtLapangan.Text == "Court F")
            {
                hargaPerJam = 80000;
            }

            // Tampilkan harga per jam ke GUI
            txtHarga.Text = hargaPerJam.ToString();


            // === 2. VALIDASI INPUTAN JAM & DURASI ===
            // Jika Jam Mulai atau Durasi masih kosong, berhenti di sini dulu (tapi harga di atas sudah aman keisi)
            if (string.IsNullOrWhiteSpace(txtMulai.Text) || string.IsNullOrWhiteSpace(txtDurasi.Text))
            {
                return;
            }

            // Bersihkan format penulisan jam jika user mengetik "08.00" menjadi "08"
            string jamText = txtMulai.Text.Replace(".00", "").Replace(":00", "").Trim();

            if (!int.TryParse(jamText, out int jamMulai))
                return;

            if (!int.TryParse(txtDurasi.Text, out int durasi))
                return;


            // === 3. HITUNG OTOMATIS LAINNYA JIKA JAM & DURASI SUDAH DIISI ===

            // Hitung Jam Selesai
            int jamSelesai = jamMulai + durasi;
            txtSelesai.Text = jamSelesai.ToString("00") + ".00";

            // Hitung Harga Awal
            double hargaAwal = hargaPerJam * durasi;
            txtAwal.Text = hargaAwal.ToString();

            // Hitung Pajak dari ConfigService
            ConfigService config = new ConfigService();
            decimal tax = config.GetTax();
            double pajak = hargaAwal * (double)tax;
            txtTax.Text = pajak.ToString();

            // Hitung Total Akhir
            txtTotal.Text = (hargaAwal + pajak).ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
            "Yakin ingin membatalkan reservasi?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                FilterJadwalForms form =
                    new FilterJadwalForms();

                this.Hide();

                form.ShowDialog();

                this.Close();
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            try
            {
                Booking booking =
      new Booking();

                booking.NamaPemesan =
                    txtNamaPemesan.Text;

                booking.HariMulai =
                    DateTime.Parse(
                        txtHari.Text);

                booking.JamMulai =
                    txtMulai.Text;

                booking.JamSelesai =
                    txtSelesai.Text;

                booking.Durasi =
                    int.Parse(
                        txtDurasi.Text);

                booking.HargaAwal =
                    double.Parse(
                        txtAwal.Text);

                booking.Pajak =
                    double.Parse(
                        txtTax.Text);

                booking.TotalHarga =
                    double.Parse(
                        txtTotal.Text);

                booking.Bayar();

                lblStatus.Text =
                    booking.Status.ToString();

                MessageBox.Show(
                    "Reservasi berhasil dibayar!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDurasi_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void txtMulai_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void txtLapangan_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void txtGedung_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHari_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }
    }
}
