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
            btnRegular = new Button();
            btnVIP = new Button();
            lblPilihan = new Label();
            dgnJadwal = new DataGridView();
            btnKembali = new Button();
            lblLanjutReservasi = new Button();
            lblHarga = new Label();
            lblFasilitas = new Label();
            colJam = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgnJadwal).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F);
            lblTitle.Location = new Point(388, 29);
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
            lblTipe.Location = new Point(107, 128);
            lblTipe.Name = "lblTipe";
            lblTipe.Size = new Size(163, 23);
            lblTipe.TabIndex = 1;
            lblTipe.Text = "Pilih Tipe Lapangan:";
            lblTipe.Click += label2_Click;
            // 
            // btnRegular
            // 
            btnRegular.Location = new Point(107, 172);
            btnRegular.Name = "btnRegular";
            btnRegular.Size = new Size(94, 29);
            btnRegular.TabIndex = 2;
            btnRegular.Text = "Regular";
            btnRegular.UseVisualStyleBackColor = true;
            // 
            // btnVIP
            // 
            btnVIP.Location = new Point(107, 219);
            btnVIP.Name = "btnVIP";
            btnVIP.Size = new Size(94, 29);
            btnVIP.TabIndex = 3;
            btnVIP.Text = "VIP";
            btnVIP.UseVisualStyleBackColor = true;
            // 
            // lblPilihan
            // 
            lblPilihan.AutoSize = true;
            lblPilihan.Location = new Point(107, 277);
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
            dgnJadwal.Columns.AddRange(new DataGridViewColumn[] { colJam, colStatus });
            dgnJadwal.Location = new Point(518, 119);
            dgnJadwal.Name = "dgnJadwal";
            dgnJadwal.ReadOnly = true;
            dgnJadwal.RowHeadersWidth = 51;
            dgnJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgnJadwal.Size = new Size(412, 333);
            dgnJadwal.TabIndex = 5;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(107, 406);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 6;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // lblLanjutReservasi
            // 
            lblLanjutReservasi.Location = new Point(228, 406);
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
            lblHarga.Location = new Point(107, 319);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(67, 20);
            lblHarga.TabIndex = 8;
            lblHarga.Text = "Harga : -";
            lblHarga.Click += lblHarga_Click;
            // 
            // lblFasilitas
            // 
            lblFasilitas.AutoSize = true;
            lblFasilitas.Location = new Point(107, 357);
            lblFasilitas.Name = "lblFasilitas";
            lblFasilitas.Size = new Size(77, 20);
            lblFasilitas.TabIndex = 9;
            lblFasilitas.Text = "Fasilitas : -";
            lblFasilitas.Click += lblFasilitas_Click;
            // 
            // colJam
            // 
            colJam.HeaderText = "Jam";
            colJam.MinimumWidth = 6;
            colJam.Name = "colJam";
            colJam.ReadOnly = true;
            colJam.Width = 180;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 180;
            // 
            // FormJadwalLapangan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 715);
            Controls.Add(lblFasilitas);
            Controls.Add(lblHarga);
            Controls.Add(lblLanjutReservasi);
            Controls.Add(btnKembali);
            Controls.Add(dgnJadwal);
            Controls.Add(lblPilihan);
            Controls.Add(btnVIP);
            Controls.Add(btnRegular);
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
        private Button btnRegular;
        private Button btnVIP;
        private Label lblPilihan;
        private DataGridView dgnJadwal;
        private Button btnKembali;
        private Button lblLanjutReservasi;
        private Label lblHarga;
        private Label lblFasilitas;
        private DataGridViewTextBoxColumn colJam;
        private DataGridViewTextBoxColumn colStatus;
    }
}