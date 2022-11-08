using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using doDonor.Models;
using Npgsql;

namespace doDonor
{
    public partial class FormPermohonan : Form
    {
        public FormPermohonan()
        {
            InitializeComponent();
        }

        private void FormPermohonan_Load(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DonorRequest req = new DonorRequest(
                        tbPatientName.Text,
                        cbBloodType.Text + cbRhesus.Text,
                        int.Parse(tbBagQuantity.Text),
                        cbDonorType.Text,
                        cbRegion.Text,
                        tbHospitalName.Text,
                        tbCpName.Text,
                        tbCpPhoneNumber.Text
                    );
            DbDonorRequest dbReq = new DbDonorRequest();
            int status = dbReq.Create(req);
            if (status == 1)
            {
                MessageBox.Show("Permintaan donor darah Anda berhasil dikirimkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbPatientName.Text = cbBloodType.Text = cbRhesus.Text = tbBagQuantity.Text = cbDonorType.Text
                            = cbRegion.Text = tbHospitalName.Text = tbCpName.Text = tbCpPhoneNumber.Text = "";
            } else
            {
                MessageBox.Show("Data gagal dikirimkan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
