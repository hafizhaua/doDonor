using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Drawing;
using System.Xml.Linq;

namespace doDonor.Models
{
    internal class DbDonorRequest : IDbCRUD
    {
        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=dodonor";
        private static NpgsqlCommand cmd;
        private string sql = null;
        private string[] aliasHeader = { "ID", "Nama Pasien", "Gol. Darah", "Jml Kantong", "Tipe Donor", "Wilayah", "Nama RS", "Nama CP", "Kontak CP" };

        public int Create(DonorRequest req)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from donor_req_insert(:_patient_name, :_blood_type, :_bag_quantity, :_donor_type, :_region, :_hospital_name, :_cp_name, :_cp_phone_number)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_patient_name", req.PatientName);
                cmd.Parameters.AddWithValue("_blood_type", req.BloodType);
                cmd.Parameters.AddWithValue("_bag_quantity", req.BagQuantity);
                cmd.Parameters.AddWithValue("_donor_type", req.DonorType);
                cmd.Parameters.AddWithValue("_region", req.Region);
                cmd.Parameters.AddWithValue("_hospital_name", req.HospitalName);
                cmd.Parameters.AddWithValue("_cp_name", req.CpName);
                cmd.Parameters.AddWithValue("_cp_phone_number", req.CpPhoneNumber);

                int status = (int)cmd.ExecuteScalar();
                conn.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Data gagal dikirimkan.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return 0;
            }
        }

        public int Update(DonorRequest req)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from donor_req_update(:_id, :_patient_name, :_blood_type, :_bag_quantity, :_donor_type, :_region, :_hospital_name, :_cp_name, :_cp_phone_number)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", req.IdDonorRequest);
                cmd.Parameters.AddWithValue("_patient_name", req.PatientName);
                cmd.Parameters.AddWithValue("_blood_type", req.BloodType);
                cmd.Parameters.AddWithValue("_bag_quantity", req.BagQuantity);
                cmd.Parameters.AddWithValue("_donor_type", req.DonorType);
                cmd.Parameters.AddWithValue("_region", req.Region);
                cmd.Parameters.AddWithValue("_hospital_name", req.HospitalName);
                cmd.Parameters.AddWithValue("_cp_name", req.CpName);
                cmd.Parameters.AddWithValue("_cp_phone_number", req.CpPhoneNumber);

                int status = (int)cmd.ExecuteScalar();
                conn.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Data gagal diperbarui.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return 0;
            }
        }

        public int Delete(string reqId)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from donor_req_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", reqId);

                int status = (int)cmd.ExecuteScalar();
                conn.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Data gagal dihapus.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return 0;
            }
        }

        public DataTable Search(DataTable dt, string bloodType, string region, string name)
        {
            bloodType = bloodType == "Semua" ? "true" : "_blood_type = '" + bloodType + "'";
            region = region == "Semua" ? "true" : "_region = '" + region + "'";
            name = name == "" ? "true" : "_patient_name ILIKE '%" + name + "%'";

            string cond = $"{bloodType} and {region} and {name};";

            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from donor_req_select() where " + cond;
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dt.Columns[i].ColumnName = aliasHeader[i];
                }
                conn.Close();
                return dt;
                
            } catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return null;
            }
        }

    }
}
