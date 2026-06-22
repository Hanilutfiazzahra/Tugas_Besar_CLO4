using System;
using System.Windows.Forms;
using Tugas_Besar_CLO4.Config;

namespace Tugas_Besar_CLO4.Forms
{
    public partial class FormAdminConfig : Form
    {
        public FormAdminConfig()
        {
            InitializeComponent();
        }

        private void FormAdminConfig_Load(object sender, EventArgs e)
        {
            decimal currentTax = ConfigService.Instance.GetTax() * 100;
            decimal currentDiscount = ConfigService.Instance.GetDiscount() * 100;

            txtTax.Text = currentTax.ToString("0.##");
            txtDiscount.Text = currentDiscount.ToString("0.##");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                decimal newTax = decimal.Parse(txtTax.Text) / 100m;
                decimal newDiscount = decimal.Parse(txtDiscount.Text) / 100m;

                ConfigService.Instance.UpdateConfig(newTax, newDiscount);

                MessageBox.Show("Konfigurasi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Pastikan format input berupa angka yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}