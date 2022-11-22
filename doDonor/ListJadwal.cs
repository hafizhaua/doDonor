using doDonor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doDonor
{
    public partial class ListJadwal : UserControl
    {
        public ListJadwal()
        {
            InitializeComponent();
        }

        private string _PMI;
        private string _lokasiPMI;
        private DateTime _waktuJadwal;
        private string _id;
        private string _alamat;

        [Category("Custom Props")]
        public  string PMI
        {
            get { return _PMI; }
            set { _PMI = value; lblPMI.Text = value;  }
        }

        [Category("Custom Props")]
        public string lokasiPMI
        {
            get { return _lokasiPMI; }
            set { _lokasiPMI = value; lblLokasi.Text = value; }
        }

        [Category("Custom Props")]
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }


        [Category("Custom Props")]
        public DateTime waktuJadwal { 
            get { return _waktuJadwal; }
            set { _waktuJadwal = value; lblTanggal.Text = value.ToString("dd MMMM yyyy"); }
        }

        [Category("Custom Props")]
        public string alamat
        {
            get { return _alamat; }
            set { _alamat = value; lblAlamat.Text = value.ToString(); }
        }

        private void ListJadwal_Load(object sender, EventArgs e)
        {
            if(FormLogin.isAdmin)
            {
                btnDelete.Visible = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Boolean isConfirmedDelete = MessageBox.Show("Apakah Anda yakin akan menghapus data ini?", "Data berhasil dihapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;

            if (isConfirmedDelete)
            {
                DbSchedule dbReq = new DbSchedule();
                int status = dbReq.Delete(id);
                if (status == 1)
                {
                    MessageBox.Show("Data permohonan donor darah berhasil dihapus. Silakan refresh data.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListJadwal_Load_1(object sender, EventArgs e)
        {
            if (FormLogin.isAdmin)
            {
                btnDelete.Visible = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Visible = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
