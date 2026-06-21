namespace Tugas_Besar_CLO4.Forms.Customer
{
    partial class FormJadwalLapangan
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
            lblTitle = new Label();
            lblTipe = new Label();
            lblPilihan = new Label();
            dgnJadwal = new DataGridView();
            clmJadwal1 = new DataGridViewTextBoxColumn();
            clmStatus2 = new DataGridViewTextBoxColumn();
            clmJadwal2 = new DataGridViewTextBoxColumn();
            clmStatus1 = new DataGridViewTextBoxColumn();
            btnKembali = new Button();
            lblLanjutReservasi = new Button();
            lblHarga = new Label();
            lblFasilitas = new Label();
            lblTanggal = new Label();
            lblGedung = new Label();
            cmbTipeLapangan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgnJadwal).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F);
            lblTitle.Location = new Point(516, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "JADWAL LAPANGAN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // lblTipe
            // 
            lblTipe.AutoSize = true;
            lblTipe.Font = new Font("Segoe UI", 10F);
            lblTipe.Location = new Point(126, 222);
            lblTipe.Name = "lblTipe";
            lblTipe.Size = new Size(163, 23);
            lblTipe.TabIndex = 1;
            lblTipe.Text = "Pilih Tipe Lapangan:";
            lblTipe.Click += label2_Click;
            // 
            // lblPilihan
            // 
            lblPilihan.AutoSize = true;
            lblPilihan.Location = new Point(126, 333);
            lblPilihan.Name = "lblPilihan";
            lblPilihan.Size = new Size(208, 20);
            lblPilihan.TabIndex = 4;
            lblPilihan.Text = "Tipe Lapangan : Belum Dipilih";
            lblPilihan.Click += lblPilihan_Click;
            // 
            // dgnJadwal
            // 
            dgnJadwal.AllowUserToAddRows = false;
            dgnJadwal.AllowUserToDeleteRows = false;
            dgnJadwal.AllowUserToResizeColumns = false;
            dgnJadwal.AllowUserToResizeRows = false;
            dgnJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgnJadwal.Columns.AddRange(new DataGridViewColumn[] { clmJadwal1, clmStatus2, clmJadwal2, clmStatus1 });
            dgnJadwal.Location = new Point(516, 126);
            dgnJadwal.Name = "dgnJadwal";
            dgnJadwal.ReadOnly = true;
            dgnJadwal.RowHeadersWidth = 51;
            dgnJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgnJadwal.Size = new Size(740, 240);
            dgnJadwal.TabIndex = 5;
            // 
            // clmJadwal1
            // 
            clmJadwal1.HeaderText = "Jadwal 1";
            clmJadwal1.MinimumWidth = 6;
            clmJadwal1.Name = "clmJadwal1";
            clmJadwal1.ReadOnly = true;
            clmJadwal1.Width = 170;
            // 
            // clmStatus2
            // 
            clmStatus2.HeaderText = "Status";
            clmStatus2.MinimumWidth = 6;
            clmStatus2.Name = "clmStatus2";
            clmStatus2.ReadOnly = true;
            clmStatus2.Width = 170;
            // 
            // clmJadwal2
            // 
            clmJadwal2.HeaderText = "Jadwal 2";
            clmJadwal2.MinimumWidth = 6;
            clmJadwal2.Name = "clmJadwal2";
            clmJadwal2.ReadOnly = true;
            clmJadwal2.Width = 170;
            // 
            // clmStatus1
            // 
            clmStatus1.HeaderText = "Status";
            clmStatus1.MinimumWidth = 6;
            clmStatus1.Name = "clmStatus1";
            clmStatus1.ReadOnly = true;
            clmStatus1.Width = 170;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(967, 400);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 6;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblLanjutReservasi
            // 
            lblLanjutReservasi.Location = new Point(1112, 400);
            lblLanjutReservasi.Name = "lblLanjutReservasi";
            lblLanjutReservasi.Size = new Size(144, 29);
            lblLanjutReservasi.TabIndex = 7;
            lblLanjutReservasi.Text = "Lanjut Reservasi";
            lblLanjutReservasi.UseVisualStyleBackColor = true;
            lblLanjutReservasi.Click += lblLanjutReservasi_Click;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(126, 367);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(67, 20);
            lblHarga.TabIndex = 8;
            lblHarga.Text = "Harga : -";
            lblHarga.Click += lblHarga_Click;
            // 
            // lblFasilitas
            // 
            lblFasilitas.AutoSize = true;
            lblFasilitas.Location = new Point(126, 400);
            lblFasilitas.Name = "lblFasilitas";
            lblFasilitas.Size = new Size(77, 20);
            lblFasilitas.TabIndex = 9;
            lblFasilitas.Text = "Fasilitas : -";
            lblFasilitas.Click += lblFasilitas_Click;
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(126, 126);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(72, 20);
            lblTanggal.TabIndex = 10;
            lblTanggal.Text = "Tanggal : ";
            // 
            // lblGedung
            // 
            lblGedung.AutoSize = true;
            lblGedung.Location = new Point(126, 160);
            lblGedung.Name = "lblGedung";
            lblGedung.Size = new Size(72, 20);
            lblGedung.TabIndex = 11;
            lblGedung.Text = "Gedung : ";
            lblGedung.Click += lblGedung_Click;
            // 
            // cmbTipeLapangan
            // 
            cmbTipeLapangan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipeLapangan.FormattingEnabled = true;
            cmbTipeLapangan.Items.AddRange(new object[] { "Regular", "VIP" });
            cmbTipeLapangan.Location = new Point(126, 259);
            cmbTipeLapangan.Name = "cmbTipeLapangan";
            cmbTipeLapangan.Size = new Size(117, 28);
            cmbTipeLapangan.TabIndex = 12;
            cmbTipeLapangan.SelectedIndexChanged += cmbTipeLapangan_SelectedIndexChanged;
            // 
            // FormJadwalLapangan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 715);
            Controls.Add(cmbTipeLapangan);
            Controls.Add(lblGedung);
            Controls.Add(lblTanggal);
            Controls.Add(lblFasilitas);
            Controls.Add(lblHarga);
            Controls.Add(lblLanjutReservasi);
            Controls.Add(btnKembali);
            Controls.Add(dgnJadwal);
            Controls.Add(lblPilihan);
            Controls.Add(lblTipe);
            Controls.Add(lblTitle);
            Name = "FormJadwalLapangan";
            Text = "FormJadwalLapangan";
            Load += FormJadwalLapangan_Load;
            ((System.ComponentModel.ISupportInitialize)dgnJadwal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTipe;
        private Label lblPilihan;
        private DataGridView dgnJadwal;
        private Button btnKembali;
        private Button lblLanjutReservasi;
        private Label lblHarga;
        private Label lblFasilitas;
        private Label lblTanggal;
        private Label lblGedung;
        private ComboBox cmbTipeLapangan;
        private DataGridViewTextBoxColumn clmJadwal1;
        private DataGridViewTextBoxColumn clmStatus2;
        private DataGridViewTextBoxColumn clmJadwal2;
        private DataGridViewTextBoxColumn clmStatus1;
    }
}