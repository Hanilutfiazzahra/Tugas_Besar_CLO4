using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tugas_Besar_CLO4.Services;

namespace Tugas_Besar_CLO4.Forms.Customer
{
    public partial class FormUser : Form
    {
        private string emailUser;

        public FormUser(string email)
        {
            InitializeComponent();
            emailUser = email;
        }

        private void FormUser_Load(
            object sender,
            EventArgs e)
        {
            lblJudul.Text =
                "Selamat Datang, User";

            lblEmail.Text =
                "Email: " + emailUser;
        }

        private async void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            DialogResult jawaban =
                MessageBox.Show(
                    "Apakah Anda ingin logout?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (jawaban == DialogResult.No)
            {
                return;
            }

            try
            {
                btnLogout.Enabled = false;

                await ApiService.Logout();

                this.Close();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "API tidak dapat dihubungi."
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Logout gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            finally
            {
                btnLogout.Enabled = true;
            }
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            FilterJadwalForms formFilterJadwal =
                new FilterJadwalForms();

            this.Hide();
            formFilterJadwal.ShowDialog();
            this.Show();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatBookingCustomer formRiwayat = new FormRiwayatBookingCustomer(emailUser);

            this.Hide();
            formRiwayat.ShowDialog();
            this.Show();
        }
    }
}