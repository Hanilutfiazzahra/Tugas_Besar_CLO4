namespace Tugas_Besar_CLO4.Forms
{
    partial class FormAdminConfig
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTax = new Label();
            txtTax = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(71, 33);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(327, 32);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Konfigurasi Pajak && Diskon";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 10F);
            lblTax.Location = new Point(57, 125);
            lblTax.Margin = new Padding(4, 0, 4, 0);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(94, 28);
            lblTax.TabIndex = 4;
            lblTax.Text = "Pajak (%):";
            // 
            // txtTax
            // 
            txtTax.Font = new Font("Segoe UI", 10F);
            txtTax.Location = new Point(214, 120);
            txtTax.Margin = new Padding(4, 5, 4, 5);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(170, 34);
            txtTax.TabIndex = 3;
            txtTax.Text = "11";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 10F);
            lblDiscount.Location = new Point(57, 192);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(109, 28);
            lblDiscount.TabIndex = 2;
            lblDiscount.Text = "Diskon (%):";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 10F);
            txtDiscount.Location = new Point(214, 187);
            txtDiscount.Margin = new Padding(4, 5, 4, 5);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(170, 34);
            txtDiscount.TabIndex = 1;
            txtDiscount.Text = "5";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(114, 267);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(229, 58);
            btnSave.TabIndex = 0;
            btnSave.Text = "Simpan Konfigurasi";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // FormAdminConfig
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 352);
            Controls.Add(btnSave);
            Controls.Add(txtDiscount);
            Controls.Add(lblDiscount);
            Controls.Add(txtTax);
            Controls.Add(lblTax);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormAdminConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel - Konfigurasi";
            Load += FormAdminConfig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnSave;
    }
}