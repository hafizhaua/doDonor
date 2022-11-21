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
    public partial class FormTambahJadwal : Form
    {
        private string region;
        public FormTambahJadwal(string reg)
        {
            region = reg;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Schedule sch = new Schedule(cbRegion.Text, dtPickDate.Value, tbLocation.Text, tbAddress.Text);
            DbSchedule db = new DbSchedule();
            int status = db.Create(sch);
            if (status == 1)
            {
                MessageBox.Show("Informasi stok darah berhasil dikirimkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Data gagal dikirimkan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTambahJadwal_Load(object sender, EventArgs e)
        {
            cbRegion.Text = region;
        }
    }
}
