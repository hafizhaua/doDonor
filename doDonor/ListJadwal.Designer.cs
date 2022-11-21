namespace doDonor
{
    partial class ListJadwal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblPMI = new System.Windows.Forms.Label();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblPMI
            // 
            this.lblPMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPMI.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPMI.Location = new System.Drawing.Point(17, 27);
            this.lblPMI.Name = "lblPMI";
            this.lblPMI.Size = new System.Drawing.Size(206, 31);
            this.lblPMI.TabIndex = 1;
            this.lblPMI.Text = "Nama PMI";
            // 
            // lblLokasi
            // 
            this.lblLokasi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLokasi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLokasi.Location = new System.Drawing.Point(17, 60);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(206, 31);
            this.lblLokasi.TabIndex = 2;
            this.lblLokasi.Text = "Lokasi";
            // 
            // lblTanggal
            // 
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTanggal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTanggal.Location = new System.Drawing.Point(17, 95);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(206, 31);
            this.lblTanggal.TabIndex = 3;
            this.lblTanggal.Text = "Waktu dan tanggal";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Brown;
            this.btnDelete.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(53, 130);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 39);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Hapus Data";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ListJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblLokasi);
            this.Controls.Add(this.lblPMI);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListJadwal";
            this.Size = new System.Drawing.Size(243, 188);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label lblTanggal;
        private Label lblLokasi;
        private Label lblPMI;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
    }
}
