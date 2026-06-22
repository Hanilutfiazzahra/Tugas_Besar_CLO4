using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Services;
using System.Linq;

namespace Tugas_Besar_CLO4.Forms.Customer
{
    public partial class FormJadwalLapangan : Form
    {

        private LapanganService lapanganService;
        private ScheduleService scheduleService;
        private List<Lapangan> daftarLapangan;

        private string jamDipilih = "";

        private DateTime _hariTerpilih;
        private string _gedungTerpilih;
        private string _emailTerpilih;
        public FormJadwalLapangan(
        DateTime hari,
         string gedung
        )
        {
            InitializeComponent();

            _hariTerpilih = hari;
            _gedungTerpilih = gedung;

            lapanganService =
                new LapanganService();

            scheduleService =
                new ScheduleService();

            daftarLapangan =
                lapanganService
                .GetLapanganByGedung(
                    gedung
                );

            lblTanggal.Text =
                "Tanggal : "
                + hari.ToString(
                    "dddd, dd MMMM yyyy"
                );

            lblGedung.Text =
                "Gedung : "
                + gedung;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPilihan_Click(object sender, EventArgs e)
        {

        }

        private void lblHarga_Click(object sender, EventArgs e)
        {

        }

        private void lblFasilitas_Click(object sender, EventArgs e)
        {

        }

        private void lblLanjutReservasi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbTipeLapangan.Text))
            {
                MessageBox.Show("Pilih tipe lapangan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data teks yang rapi untuk dilempar ke FormBooking
            string tanggalKirim = _hariTerpilih != DateTime.MinValue
                ? _hariTerpilih.ToString("dd MMMM yyyy")
                : DateTime.Now.ToString("dd MMMM yyyy");

            string gedungKirim = !string.IsNullOrEmpty(_gedungTerpilih) ? _gedungTerpilih : "Gedung A";
            string tipeLapanganKirim = cmbTipeLapangan.Text;
            string jamMulaiDefault = "";

            // constructor booking
            FormBooking booking = new FormBooking(
                _emailTerpilih,
                tanggalKirim,
                gedungKirim,
                tipeLapanganKirim,
                jamMulaiDefault
            );

            this.Hide();
            booking.ShowDialog();
            this.Show();
        }

        private void FormJadwalLapangan_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipeLapangan_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            string tipeDipilih =
                cmbTipeLapangan.Text;

            Lapangan lapangan =
                daftarLapangan
                .FirstOrDefault(
                    x => x.tipe == tipeDipilih
                );

            if (lapangan != null)
            {
                TampilkanJadwal(
                    lapangan
                );
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TampilkanJadwal(
            Lapangan lapangan
        )
        {
            dgnJadwal.Rows.Clear();

            if (
                lapangan.jadwal.Count == 0
            )
            {
                scheduleService.generateJadwal(
                    lapangan
                );
            }
                    ;

            List<Booking> semuaBooking =
    BookingService.Instance
        .GetSemuaRiwayat();

            foreach (Booking booking in semuaBooking)
            {
                if (
                    booking.HariMulai.Date != _hariTerpilih.Date
                    ||
                    booking.Gedung != _gedungTerpilih
                    ||
                    booking.TipeLapangan != lapangan.tipe
                )
                {
                    continue;
                }

                string jamMulai =
                    booking.JamMulai
                        .Replace(".00", "")
                        .Replace(":00", "");

                string jamSelesai =
                    booking.JamSelesai
                        .Replace(".00", "")
                        .Replace(":00", "");

                int mulai = int.Parse(jamMulai);
                int selesai = int.Parse(jamSelesai);

                for (int jam = mulai; jam < selesai; jam++)
                {
                    string range =
                        $"{jam:00}.00 - {jam + 1:00}.00";

                    if (lapangan.jadwal.ContainsKey(range))
                    {
                        lapangan.jadwal[range] = true;
                    }
                }
            }

            lblPilihan.Text =
                "Tipe Lapangan : "
                + lapangan.tipe;

            lblHarga.Text =
                "Harga : Rp "
                + lapangan.hargaPerJam;

            if (lapangan is LapanganVIP vip)
            {
                lblFasilitas.Text =
                    "Fasilitas : "
                    + string.Join(
                        ", ",
                        vip.fasilitas
                    );
            }
            else
            {
                lblFasilitas.Text =
                    "Fasilitas : -";
            }

            List<KeyValuePair<string, bool>>
                daftarJadwal =
                lapangan.jadwal
                .ToList();

            int tengah =
                (int)Math.Ceiling(
                    daftarJadwal.Count / 2.0
                );

            for (
                int i = 0;
                i < tengah;
                i++
            )
            {
                string jadwal1 =
                    daftarJadwal[i].Key;

                string status1 =
                    daftarJadwal[i].Value
                        ? "Booked"
                        : "Tersedia";

                string jadwal2 = "";
                string status2 = "";

                if (
                    i + tengah
                    < daftarJadwal.Count
                )
                {
                    jadwal2 =
                        daftarJadwal[
                            i + tengah
                        ].Key;

                    status2 =
                        daftarJadwal[
                            i + tengah
                        ].Value
                            ? "Booked"
                            : "Tersedia";
                }

                dgnJadwal.Rows.Add(
                    jadwal1,
                    status1,
                    jadwal2,
                    status2
                );
            }
        }
    }
}
