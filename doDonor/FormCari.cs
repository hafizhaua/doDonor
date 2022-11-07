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
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=dodonor";
        public static NpgsqlCommand cmd;

        private string sql = null;

        public DataTable dt;
        private DataGridViewRow r;

        public FormCari()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvDonorReq.DataSource = null;

                string q1 = cbBloodType.Text == "Semua" ? "true" : "_blood_type = '" + cbBloodType.Text + "'";
                string q2 = cbRegion.Text == "Semua" ? "true" : "_region = '" + cbRegion.Text + "'";

                sql = @"select * from donor_req_select() where " + q1 + " and " + q2 + ";";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dt.Columns[0].ColumnMapping = MappingType.Hidden;
                dgvDonorReq.DataSource = dt;

                MessageBox.Show(dt.Rows.Count + " data ditemukan.", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, sql, MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void FormCari_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
