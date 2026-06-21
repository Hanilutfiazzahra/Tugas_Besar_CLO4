namespace Tugas_Besar_CLO4.Forms
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblNama = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblKonfirmasi = new Label();
            txtNama = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtKonfirmasiPassword = new TextBox();
            btnRegister = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 44);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 0;
            label1.Text = "REGISTER USER";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(216, 102);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 25);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(216, 191);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(216, 277);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblKonfirmasi
            // 
            lblKonfirmasi.AutoSize = true;
            lblKonfirmasi.Location = new Point(216, 367);
            lblKonfirmasi.Name = "lblKonfirmasi";
            lblKonfirmasi.Size = new Size(176, 25);
            lblKonfirmasi.TabIndex = 4;
            lblKonfirmasi.Text = "Konfirmasi Password";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(216, 130);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(354, 31);
            txtNama.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(216, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(354, 31);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(216, 305);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(354, 31);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtKonfirmasiPassword
            // 
            txtKonfirmasiPassword.Location = new Point(216, 395);
            txtKonfirmasiPassword.Name = "txtKonfirmasiPassword";
            txtKonfirmasiPassword.Size = new Size(354, 31);
            txtKonfirmasiPassword.TabIndex = 8;
            txtKonfirmasiPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(216, 457);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(354, 52);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(38, 457);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(155, 52);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(btnKembali);
            Controls.Add(btnRegister);
            Controls.Add(txtKonfirmasiPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtNama);
            Controls.Add(lblKonfirmasi);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "FormRegister";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNama;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblKonfirmasi;
        private TextBox txtNama;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtKonfirmasiPassword;
        private Button btnRegister;
        private Button btnKembali;
    }
}