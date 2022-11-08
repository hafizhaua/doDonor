using doDonor.Models;
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
    public partial class FormCari : Form
    {

        public DataTable dt;
        public static DataGridViewRow rowSelected;

        public FormCari()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(FormLogin.isAdmin)
            {
                if (e.RowIndex >= 0)
                {
                    rowSelected = dgvDonorReq.Rows[e.RowIndex];
                    FormUpdateDonorReq formUpdate = new FormUpdateDonorReq(btnSearch);
                    formUpdate.Show();
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DbDonorRequest dbReq = new DbDonorRequest();
            dt = new DataTable();
            dt = dbReq.Search(dt, cbBloodType.Text, cbRegion.Text, tbName.Text);

            dgvDonorReq.DataSource = dt;
            dgvDonorReq.Columns["ID"].Visible = false;
            MessageBox.Show(dt.Rows.Count + " data ditemukan.", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormCari_Load(object sender, EventArgs e)
        {
            dgvDonorReq.Enabled = FormLogin.isAdmin ? true : false;
        }
    }
}
