namespace Tugas_Besar_CLO4.Forms.Admin
{
    partial class FormAdmin
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(283, 54);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(198, 32);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Halaman Admin";
            lblJudul.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(273, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 25);
            lblEmail.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(33, 365);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(178, 60);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button1
            // 
            button1.Location = new Point(273, 147);
            button1.Name = "button1";
            button1.Size = new Size(234, 60);
            button1.TabIndex = 3;
            button1.Text = "Lihat Riwayat Pesanan";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(273, 213);
            button2.Name = "button2";
            button2.Size = new Size(234, 60);
            button2.TabIndex = 4;
            button2.Text = "Konfigurasi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(273, 279);
            button3.Name = "button3";
            button3.Size = new Size(234, 60);
            button3.TabIndex = 5;
            button3.Text = "Checkout";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnLogout);
            Controls.Add(lblEmail);
            Controls.Add(lblJudul);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblEmail;
        private Button btnLogout;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}