using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Services;

namespace Tugas_Besar_CLO4.Forms
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;

            txtKonfirmasiPassword
                .UseSystemPasswordChar = true;
        }

        private async void btnRegister_Click(
            object sender,
            EventArgs e)
        {
            if (txtNama.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Nama belum diisi."
                );

                txtNama.Focus();
                return;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Email belum diisi."
                );

                txtEmail.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show(
                    "Password belum diisi."
                );

                txtPassword.Focus();
                return;
            }

            if (txtKonfirmasiPassword.Text == "")
            {
                MessageBox.Show(
                    "Konfirmasi password belum diisi."
                );

                txtKonfirmasiPassword.Focus();
                return;
            }

            if (txtPassword.Text !=
                txtKonfirmasiPassword.Text)
            {
                MessageBox.Show(
                    "Password dan konfirmasi password tidak sama.",
                    "Register gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtKonfirmasiPassword.Focus();
                return;
            }

            try
            {
                btnRegister.Enabled = false;
                btnKembali.Enabled = false;

                RegisterRequest request =
                    new RegisterRequest();

                request.Name =
                    txtNama.Text.Trim();

                request.Email =
                    txtEmail.Text.Trim();

                request.Password =
                    txtPassword.Text;

                await ApiService.Register(request);

                MessageBox.Show(
                    "Register berhasil.\n" +
                    "Silakan login menggunakan akun tersebut.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "API tidak dapat dihubungi.\n" +
                    "Pastikan project API sedang berjalan.",
                    "Koneksi gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Register gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            finally
            {
                btnRegister.Enabled = true;
                btnKembali.Enabled = true;
            }
        }

        private void btnKembali_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}