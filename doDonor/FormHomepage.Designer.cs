namespace doDonor
{
    partial class FormHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomepage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStok = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPermohonan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCari = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnJadwal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tentang Kami";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnStok
            // 
            this.btnStok.BorderRadius = 15;
            this.btnStok.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStok.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStok.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStok.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStok.ForeColor = System.Drawing.Color.White;
            this.btnStok.Location = new System.Drawing.Point(64, 158);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(212, 97);
            this.btnStok.TabIndex = 2;
            this.btnStok.Text = "Stok Darah";
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnPermohonan
            // 
            this.btnPermohonan.BorderRadius = 15;
            this.btnPermohonan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPermohonan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPermohonan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPermohonan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPermohonan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPermohonan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPermohonan.ForeColor = System.Drawing.Color.White;
            this.btnPermohonan.Location = new System.Drawing.Point(317, 158);
            this.btnPermohonan.Name = "btnPermohonan";
            this.btnPermohonan.Size = new System.Drawing.Size(212, 97);
            this.btnPermohonan.TabIndex = 3;
            this.btnPermohonan.Text = "Permohonan Donor";
            this.btnPermohonan.Click += new System.EventHandler(this.btnPermohonan_Click);
            // 
            // btnCari
            // 
            this.btnCari.BorderRadius = 15;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(317, 272);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(212, 97);
            this.btnCari.TabIndex = 5;
            this.btnCari.Text = "Cari Kebutuhan Donor";
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnJadwal
            // 
            this.btnJadwal.BorderRadius = 15;
            this.btnJadwal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJadwal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJadwal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJadwal.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJadwal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJadwal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJadwal.ForeColor = System.Drawing.Color.White;
            this.btnJadwal.Location = new System.Drawing.Point(64, 272);
            this.btnJadwal.Name = "btnJadwal";
            this.btnJadwal.Size = new System.Drawing.Size(212, 97);
            this.btnJadwal.TabIndex = 4;
            this.btnJadwal.Text = "Jadwal Donor";
            this.btnJadwal.Click += new System.EventHandler(this.btnJadwal_Click);
            // 
            // FormHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(599, 411);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnJadwal);
            this.Controls.Add(this.btnPermohonan);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHomepage";
            this.Text = "FormHomepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnStok;
        private Guna.UI2.WinForms.Guna2GradientButton btnPermohonan;
        private Guna.UI2.WinForms.Guna2GradientButton btnCari;
        private Guna.UI2.WinForms.Guna2GradientButton btnJadwal;
    }
}