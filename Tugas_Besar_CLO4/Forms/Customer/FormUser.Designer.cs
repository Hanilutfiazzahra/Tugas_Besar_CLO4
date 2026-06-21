namespace Tugas_Besar_CLO4.Forms.Customer
{
    partial class FormUser
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
            lblJudul = new Label();
            lblEmail = new Label();
            btnLogout = new Button();
            btnReservasi = new Button();
            btnRiwayat = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(303, 45);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(173, 32);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Halaman User";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(275, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 25);
            lblEmail.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(275, 363);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(240, 50);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReservasi
            // 
            btnReservasi.Location = new Point(275, 169);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Size = new Size(240, 50);
            btnReservasi.TabIndex = 3;
            btnReservasi.Text = "Reservasi";
            btnReservasi.UseVisualStyleBackColor = true;
            btnReservasi.Click += btnReservasi_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(275, 235);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(240, 50);
            btnRiwayat.TabIndex = 4;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = true;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRiwayat);
            Controls.Add(btnReservasi);
            Controls.Add(btnLogout);
            Controls.Add(lblEmail);
            Controls.Add(lblJudul);
            Name = "FormUser";
            Text = "FormUser";
            Load += FormUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblEmail;
        private Button btnLogout;
        private Button btnReservasi;
        private Button btnRiwayat;
    }
}