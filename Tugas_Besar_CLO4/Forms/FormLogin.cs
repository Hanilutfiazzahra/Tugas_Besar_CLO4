using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Services;
using Tugas_Besar_CLO4.Forms.Admin;
using Tugas_Besar_CLO4.Forms.Customer;

namespace Tugas_Besar_CLO4.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void FormLogin_Load(
            object sender,
            EventArgs e)
        {
            txtEmail.Focus();
        }

        private async void btnLogin_Click(
            object sender,
            EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Email belum diisi.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmail.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show(
                    "Password belum diisi.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPassword.Focus();
                return;
            }

            try
            {
                btnLogin.Enabled = false;
                btnRegister.Enabled = false;
                lblStatus.Text = "Memeriksa akun...";

                LoginRequest request =
                    new LoginRequest();

                request.Email =
                    txtEmail.Text.Trim();

                request.Password =
                    txtPassword.Text;

                AuthResponse hasil =
                    await ApiService.Login(request);

                string role = hasil.Role.Trim();

                MessageBox.Show(
                    "Login berhasil.\n" +
                    "Email: " + hasil.Email + "\n" +
                    "Role: " + role,
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (role.Equals(
                    "Admin",
                    StringComparison.OrdinalIgnoreCase))
                {
                    FormAdmin formAdmin =
                        new FormAdmin(hasil.Email);

                    this.Hide();

                    formAdmin.ShowDialog();

                    this.Show();
                }
                else if (role.Equals(
                    "Customer",
                    StringComparison.OrdinalIgnoreCase))
                {
                    FormUser formUser =
                        new FormUser(hasil.Email);

                    this.Hide();

                    formUser.ShowDialog();

                    this.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Role tidak dikenali: " + role,
                        "Login gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
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
                    "Login gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnLogin.Enabled = true;
                btnRegister.Enabled = true;
                lblStatus.Text = "";
            }
        }

        private void btnRegister_Click(
            object sender,
            EventArgs e)
        {
            FormRegister formRegister =
                new FormRegister();

            this.Hide();

            formRegister.ShowDialog();

            this.Show();
        }
    }
}