namespace Tugas_Besar_CLO4.Forms.Customer
{
    partial class FilterJadwalForms
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
            label2 = new Label();
            cmbGedung = new ComboBox();
            btnBack = new Button();
            btnFilter = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpHari = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 105);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Pilih Hari : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 202);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Pilih Gedung :";
            // 
            // cmbGedung
            // 
            cmbGedung.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGedung.FormattingEnabled = true;
            cmbGedung.Location = new Point(265, 225);
            cmbGedung.Name = "cmbGedung";
            cmbGedung.Size = new Size(250, 28);
            cmbGedung.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(265, 293);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(421, 293);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(217, 45);
            label3.Name = "label3";
            label3.Size = new Size(379, 41);
            label3.TabIndex = 6;
            label3.Text = "FILTER JADWAL LAPANGAN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(383, 386);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Catatan : ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 386);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(383, 410);
            label6.Name = "label6";
            label6.Size = new Size(405, 20);
            label6.TabIndex = 9;
            label6.Text = "Pemesanan hanya dapat dilakukan maksimal 7 hari ke depan.";
            // 
            // dtpHari
            // 
            dtpHari.Format = DateTimePickerFormat.Custom;
            dtpHari.Location = new Point(265, 128);
            dtpHari.Name = "dtpHari";
            dtpHari.Size = new Size(250, 27);
            dtpHari.TabIndex = 10;
            dtpHari.ValueChanged += dtpHari_ValueChanged;
            // 
            // FilterJadwalForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpHari);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnFilter);
            Controls.Add(btnBack);
            Controls.Add(cmbGedung);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FilterJadwalForms";
            Text = "FilterJadwalForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbGedung;
        private Button btnBack;
        private Button btnFilter;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpHari;
    }
}