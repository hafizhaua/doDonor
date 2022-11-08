using doDonor.Models;
using Guna.UI2.WinForms;
using Npgsql;
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
    public partial class FormUpdateDonorReq : Form
    {

        private Guna2GradientButton _refreshBtn;
        private DataGridViewRow r;

        public FormUpdateDonorReq(Guna2GradientButton btn)
        {
            _refreshBtn = btn;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DonorRequest req = new DonorRequest(
                      lblID.Text,
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
            int status = dbReq.Update(req);
            if (status == 1)
            {
                MessageBox.Show("Data permohonan donor darah berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _refreshBtn.PerformClick();
                Close();
            }
            else
            {
                MessageBox.Show("Data gagal diperbarui.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormUpdateDonorReq_Load(object sender, EventArgs e)
        {
            r = FormCari.rowSelected;
            tbPatientName.Text = r.Cells["Nama Pasien"].Value.ToString();
            cbBloodType.Text = r.Cells["Gol. Darah"].Value.ToString().Substring(0, r.Cells["Gol. Darah"].Value.ToString().Length-1);
            cbRhesus.Text = r.Cells["Gol. Darah"].Value.ToString().Substring(r.Cells["Gol. Darah"].Value.ToString().Length - 1);
            tbBagQuantity.Text = r.Cells["Jml Kantong"].Value.ToString();
            cbDonorType.Text = r.Cells["Tipe Donor"].Value.ToString();
            cbRegion.Text = r.Cells["Wilayah"].Value.ToString();
            tbHospitalName.Text = r.Cells["Nama RS"].Value.ToString();
            tbCpName.Text = r.Cells["Nama CP"].Value.ToString();
            tbCpPhoneNumber.Text = r.Cells["Kontak CP"].Value.ToString();
            lblID.Text = r.Cells["ID"].Value.ToString();
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Boolean isConfirmedDelete = MessageBox.Show("Apakah Anda yakin akan menghapus data ini?", "Data berhasil dihapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;

            if (isConfirmedDelete)
            {
                DbDonorRequest dbReq = new DbDonorRequest();
                int status = dbReq.Delete(r.Cells["ID"].Value.ToString());
                if (status == 1)
                {
                    MessageBox.Show("Data permohonan donor darah berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _refreshBtn.PerformClick();
                    Close();
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
