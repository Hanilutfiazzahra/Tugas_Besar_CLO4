namespace Tugas_Besar_CLO4.Forms.Customer
{
    partial class FormBooking
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
            lblHari = new Label();
            lblGedung = new Label();
            lblLapangan = new Label();
            lblMulai = new Label();
            lblDurasi = new Label();
            lblHarga = new Label();
            lblSelesai = new Label();
            lblAwal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            lblStatus = new Label();
            txtStatus = new Label();
            txtNamaPemesan = new TextBox();
            txtHari = new TextBox();
            txtGedung = new TextBox();
            txtLapangan = new TextBox();
            txtMulai = new TextBox();
            txtDurasi = new TextBox();
            txtHarga = new TextBox();
            txtSelesai = new TextBox();
            txtAwal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnBayar = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            label16 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            txtPersenDiskon = new TextBox();
            txtPersenTax = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Melakukan Reservasi";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(12, 48);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(111, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Pemesan";
            // 
            // lblHari
            // 
            lblHari.AutoSize = true;
            lblHari.Location = new Point(12, 97);
            lblHari.Name = "lblHari";
            lblHari.Size = new Size(78, 20);
            lblHari.TabIndex = 2;
            lblHari.Text = "Hari Mulai";
            // 
            // lblGedung
            // 
            lblGedung.AutoSize = true;
            lblGedung.Location = new Point(12, 145);
            lblGedung.Name = "lblGedung";
            lblGedung.Size = new Size(61, 20);
            lblGedung.TabIndex = 3;
            lblGedung.Text = "Gedung";
            // 
            // lblLapangan
            // 
            lblLapangan.AutoSize = true;
            lblLapangan.Location = new Point(12, 195);
            lblLapangan.Name = "lblLapangan";
            lblLapangan.Size = new Size(74, 20);
            lblLapangan.TabIndex = 4;
            lblLapangan.Text = "Lapangan";
            // 
            // lblMulai
            // 
            lblMulai.AutoSize = true;
            lblMulai.Location = new Point(12, 251);
            lblMulai.Name = "lblMulai";
            lblMulai.Size = new Size(76, 20);
            lblMulai.TabIndex = 5;
            lblMulai.Text = "Jam Mulai";
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Location = new Point(12, 301);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(51, 20);
            lblDurasi.TabIndex = 6;
            lblDurasi.Text = "Durasi";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(480, 41);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(90, 20);
            lblHarga.TabIndex = 7;
            lblHarga.Text = "Harga / Jam";
            // 
            // lblSelesai
            // 
            lblSelesai.AutoSize = true;
            lblSelesai.Location = new Point(480, 97);
            lblSelesai.Name = "lblSelesai";
            lblSelesai.Size = new Size(85, 20);
            lblSelesai.TabIndex = 8;
            lblSelesai.Text = "Jam Selesai";
            // 
            // lblAwal
            // 
            lblAwal.AutoSize = true;
            lblAwal.Location = new Point(480, 145);
            lblAwal.Name = "lblAwal";
            lblAwal.Size = new Size(87, 20);
            lblAwal.TabIndex = 9;
            lblAwal.Text = "Harga Awal";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(480, 251);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(88, 20);
            lblTax.TabIndex = 10;
            lblTax.Text = "Harga Pajak";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(480, 356);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(87, 20);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total Harga";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(480, 413);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status";
            lblStatus.Click += label13_Click;
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(668, 413);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(62, 20);
            txtStatus.TabIndex = 13;
            txtStatus.Text = "Pending";
            // 
            // txtNamaPemesan
            // 
            txtNamaPemesan.Location = new Point(238, 41);
            txtNamaPemesan.Name = "txtNamaPemesan";
            txtNamaPemesan.Size = new Size(125, 27);
            txtNamaPemesan.TabIndex = 14;
            txtNamaPemesan.TextChanged += textBox1_TextChanged;
            // 
            // txtHari
            // 
            txtHari.Location = new Point(238, 90);
            txtHari.Name = "txtHari";
            txtHari.ReadOnly = true;
            txtHari.Size = new Size(125, 27);
            txtHari.TabIndex = 15;
            txtHari.TextChanged += txtHari_TextChanged;
            // 
            // txtGedung
            // 
            txtGedung.Location = new Point(238, 138);
            txtGedung.Name = "txtGedung";
            txtGedung.ReadOnly = true;
            txtGedung.Size = new Size(125, 27);
            txtGedung.TabIndex = 16;
            txtGedung.TextChanged += txtGedung_TextChanged;
            // 
            // txtLapangan
            // 
            txtLapangan.Location = new Point(238, 188);
            txtLapangan.Name = "txtLapangan";
            txtLapangan.ReadOnly = true;
            txtLapangan.Size = new Size(125, 27);
            txtLapangan.TabIndex = 17;
            txtLapangan.TextChanged += txtLapangan_TextChanged;
            // 
            // txtMulai
            // 
            txtMulai.Location = new Point(238, 244);
            txtMulai.Name = "txtMulai";
            txtMulai.Size = new Size(125, 27);
            txtMulai.TabIndex = 18;
            txtMulai.TextChanged += txtMulai_TextChanged;
            // 
            // txtDurasi
            // 
            txtDurasi.Location = new Point(238, 294);
            txtDurasi.Name = "txtDurasi";
            txtDurasi.Size = new Size(125, 27);
            txtDurasi.TabIndex = 19;
            txtDurasi.TextChanged += txtDurasi_TextChanged;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(668, 34);
            txtHarga.Name = "txtHarga";
            txtHarga.ReadOnly = true;
            txtHarga.Size = new Size(125, 27);
            txtHarga.TabIndex = 20;
            // 
            // txtSelesai
            // 
            txtSelesai.Location = new Point(668, 90);
            txtSelesai.Name = "txtSelesai";
            txtSelesai.ReadOnly = true;
            txtSelesai.Size = new Size(125, 27);
            txtSelesai.TabIndex = 21;
            // 
            // txtAwal
            // 
            txtAwal.Location = new Point(668, 142);
            txtAwal.Name = "txtAwal";
            txtAwal.ReadOnly = true;
            txtAwal.Size = new Size(125, 27);
            txtAwal.TabIndex = 22;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(668, 248);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(125, 27);
            txtTax.TabIndex = 23;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(668, 349);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 48);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 25;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 97);
            label3.Name = "label3";
            label3.Size = new Size(12, 20);
            label3.TabIndex = 26;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 145);
            label4.Name = "label4";
            label4.Size = new Size(12, 20);
            label4.TabIndex = 27;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 195);
            label5.Name = "label5";
            label5.Size = new Size(12, 20);
            label5.TabIndex = 28;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 251);
            label6.Name = "label6";
            label6.Size = new Size(12, 20);
            label6.TabIndex = 29;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 301);
            label7.Name = "label7";
            label7.Size = new Size(12, 20);
            label7.TabIndex = 30;
            label7.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(603, 41);
            label8.Name = "label8";
            label8.Size = new Size(12, 20);
            label8.TabIndex = 31;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(603, 97);
            label9.Name = "label9";
            label9.Size = new Size(12, 20);
            label9.TabIndex = 32;
            label9.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(603, 145);
            label10.Name = "label10";
            label10.Size = new Size(12, 20);
            label10.TabIndex = 33;
            label10.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(603, 195);
            label11.Name = "label11";
            label11.Size = new Size(12, 20);
            label11.TabIndex = 34;
            label11.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(603, 251);
            label12.Name = "label12";
            label12.Size = new Size(12, 20);
            label12.TabIndex = 35;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(603, 301);
            label13.Name = "label13";
            label13.Size = new Size(12, 20);
            label13.TabIndex = 36;
            label13.Text = ":";
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(480, 498);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(94, 29);
            btnBayar.TabIndex = 37;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(699, 498);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 498);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 39;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(480, 301);
            label16.Name = "label16";
            label16.Size = new Size(76, 20);
            label16.TabIndex = 40;
            label16.Text = "Diskon(%)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(480, 195);
            label14.Name = "label14";
            label14.Size = new Size(65, 20);
            label14.TabIndex = 41;
            label14.Text = "Pajak(%)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(603, 356);
            label15.Name = "label15";
            label15.Size = new Size(12, 20);
            label15.TabIndex = 42;
            label15.Text = ":";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(603, 413);
            label17.Name = "label17";
            label17.Size = new Size(12, 20);
            label17.TabIndex = 43;
            label17.Text = ":";
            // 
            // txtPersenDiskon
            // 
            txtPersenDiskon.Location = new Point(668, 298);
            txtPersenDiskon.Name = "txtPersenDiskon";
            txtPersenDiskon.ReadOnly = true;
            txtPersenDiskon.Size = new Size(125, 27);
            txtPersenDiskon.TabIndex = 44;
            // 
            // txtPersenTax
            // 
            txtPersenTax.Location = new Point(668, 192);
            txtPersenTax.Name = "txtPersenTax";
            txtPersenTax.ReadOnly = true;
            txtPersenTax.Size = new Size(125, 27);
            txtPersenTax.TabIndex = 45;
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 535);
            Controls.Add(txtPersenTax);
            Controls.Add(txtPersenDiskon);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(btnBayar);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtAwal);
            Controls.Add(txtSelesai);
            Controls.Add(txtHarga);
            Controls.Add(txtDurasi);
            Controls.Add(txtMulai);
            Controls.Add(txtLapangan);
            Controls.Add(txtGedung);
            Controls.Add(txtHari);
            Controls.Add(txtNamaPemesan);
            Controls.Add(txtStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblAwal);
            Controls.Add(lblSelesai);
            Controls.Add(lblHarga);
            Controls.Add(lblDurasi);
            Controls.Add(lblMulai);
            Controls.Add(lblLapangan);
            Controls.Add(lblGedung);
            Controls.Add(lblHari);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Name = "FormBooking";
            Text = "FormBooking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNama;
        private Label lblHari;
        private Label lblGedung;
        private Label lblLapangan;
        private Label lblMulai;
        private Label lblDurasi;
        private Label lblHarga;
        private Label lblSelesai;
        private Label lblAwal;
        private Label lblTax;
        private Label lblTotal;
        private Label lblStatus;
        private Label txtStatus;
        private TextBox txtNamaPemesan;
        private TextBox txtHari;
        private TextBox txtGedung;
        private TextBox txtLapangan;
        private TextBox txtMulai;
        private TextBox txtDurasi;
        private TextBox txtHarga;
        private TextBox txtSelesai;
        private TextBox txtAwal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnBayar;
        private Button btnCancel;
        private Button btnBack;
        private Label label16;
        private Label label14;
        private Label label15;
        private Label label17;
        private TextBox txtPersenDiskon;
        private TextBox txtPersenTax;
    }
}