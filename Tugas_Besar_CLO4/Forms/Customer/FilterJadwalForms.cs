using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Services;

namespace Tugas_Besar_CLO4.Forms.Customer
{
    public partial class FilterJadwalForms : Form
    {
        public FilterJadwalForms()
        {

            InitializeComponent();

            dtpHari.Format =
                DateTimePickerFormat.Custom;


            dtpHari.CustomFormat =
                "dddd,dd MMMM yyyy";

            LoadGedung();

            dtpHari.MinDate =
                DateTime.Today;

            dtpHari.MaxDate =
                DateTime.Today.AddDays(7);

        }


        private void LoadGedung()
        {
            cmbGedung.Items.Clear();

            LapanganService service =
                new LapanganService();

            List<string> daftarGedung =
                service.GetDaftarGedung();

            foreach (string gedung in daftarGedung)
            {
                cmbGedung.Items.Add(gedung);
            }

            cmbGedung.SelectedIndex = -1;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGedung.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Silakan pilih gedung terlebih dahulu.",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                FilterJadwal filter =
                    new FilterJadwal();

                filter.Hari =
                    dtpHari.Value.Date;

                filter.Gedung =
                    cmbGedung.Text;

                string tanggal =
                    filter.Hari.ToString(
                        "dddd, dd MMMM yyyy"
                    );

                DialogResult hasil =
                    MessageBox.Show(
                        "Hari : " + tanggal
                        + "\nGedung : " + filter.Gedung
                        + "\n\nLanjutkan ke halaman jadwal lapangan?",
                        "Konfirmasi Filter Jadwal",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (hasil == DialogResult.Yes)
                {
                    FormJadwalLapangan form =
                        new FormJadwalLapangan();

                    this.Hide();

                    form.ShowDialog();

                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan : " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpHari_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FilterJadwalForms_Load(object sender, EventArgs e)
        {

        }
    }
}
