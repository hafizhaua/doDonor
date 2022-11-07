using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            conn = new NpgsqlConnection(connstring);
        }

        private static string NullIfEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Pastikan semua data telah terisi.");
                return null;
            }
            return value;
        }

        private static int PositiveOnly(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Masukkan data numeris dengan benar.");
            }
            return value;
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=dodonor";
        public static NpgsqlCommand cmd;

        private string sql = null;


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from donor_req_insert(:_patient_name, :_blood_type, :_bag_quantity, :_donor_type, :_region, :_hospital_name, :_cp_name, :_cp_phone_number)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_patient_name", NullIfEmpty(tbPatientName.Text));
                cmd.Parameters.AddWithValue("_blood_type", NullIfEmpty(cbBloodType.Text + cbRhesus.Text));
                cmd.Parameters.AddWithValue("_bag_quantity", PositiveOnly(int.Parse(tbBagQuantity.Text)));
                cmd.Parameters.AddWithValue("_donor_type", NullIfEmpty(cbDonorType.Text));
                cmd.Parameters.AddWithValue("_region", NullIfEmpty(cbRegion.Text));
                cmd.Parameters.AddWithValue("_hospital_name", NullIfEmpty(tbHospitalName.Text));
                cmd.Parameters.AddWithValue("_cp_name", NullIfEmpty(tbCpName.Text));
                cmd.Parameters.AddWithValue("_cp_phone_number", NullIfEmpty(tbCpPhoneNumber.Text));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Permintaan donor darah Anda berhasil dikirimkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                    tbPatientName.Text = cbBloodType.Text = cbRhesus.Text = tbBagQuantity.Text = cbDonorType.Text
                        = cbRegion.Text = tbHospitalName.Text = tbCpName.Text = tbCpPhoneNumber.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Data gagal dikirimkan.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

    }
}
