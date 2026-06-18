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

        public FormJadwalLapangan()
        {
            InitializeComponent();

            lapanganService =
                new LapanganService();

            scheduleService =
                new ScheduleService();

            daftarLapangan =
                lapanganService
                .GetLapanganByGedung(
                    "Gedung A"
                );

            lblTanggal.Text =
                "Tanggal : "
                + DateTime.Now.ToString(
                    "dd MMMM yyyy"
                );

            lblGedung.Text =
                "Gedung : Gedung A";
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

        }

        private void TampilkanJadwal(
    Lapangan lapangan
)
        {
            dgnJadwal.Rows.Clear();

            lapangan.jadwal.Clear();

            scheduleService.generateJadwal(
                lapangan
            );

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
