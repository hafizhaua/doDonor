using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal class DbBloodStock
    {
        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=dodonor";
        private static NpgsqlCommand cmd;
        private string sql = null;

        public int Create(BloodStock stock)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from blood_stock_insert(:_region, :_wb_a, :_wb_b, :_wb_ab, :_wb_o, :_tc_a, :_tc_b, :_tc_ab, :_tc_o, :_prc_a, :_prc_b, :_prc_ab, :_prc_o, :_date_stock)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_region", stock.Region);
                cmd.Parameters.AddWithValue("_wb_a", stock.WbA);
                cmd.Parameters.AddWithValue("_wb_b", stock.WbB);
                cmd.Parameters.AddWithValue("_wb_ab", stock.WbAb);
                cmd.Parameters.AddWithValue("_wb_o", stock.WbO);
                cmd.Parameters.AddWithValue("_tc_a", stock.TcA);
                cmd.Parameters.AddWithValue("_tc_b", stock.TcB);
                cmd.Parameters.AddWithValue("_tc_ab", stock.TcAb);
                cmd.Parameters.AddWithValue("_tc_o", stock.TcO);
                cmd.Parameters.AddWithValue("_prc_a", stock.PrcA);
                cmd.Parameters.AddWithValue("_prc_b", stock.PrcB);
                cmd.Parameters.AddWithValue("_prc_ab", stock.PrcAb);
                cmd.Parameters.AddWithValue("_prc_o", stock.PrcO);
                cmd.Parameters.Add(new NpgsqlParameter("_date_stock", NpgsqlTypes.NpgsqlDbType.Date)).Value = stock.DateStock;

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

        public int Update(BloodStock stock)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from blood_stock_update(:_id, :_region, :_wb_a, :_wb_b, :_wb_ab, :_wb_o, :_tc_a, :_tc_b, :_tc_ab, :_tc_o, :_prc_a, :_prc_b, :_prc_ab, :_prc_o, :_date_stock)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", stock.Id);
                cmd.Parameters.AddWithValue("_region", stock.Region);
                cmd.Parameters.AddWithValue("_wb_a", stock.WbA);
                cmd.Parameters.AddWithValue("_wb_b", stock.WbB);
                cmd.Parameters.AddWithValue("_wb_ab", stock.WbAb);
                cmd.Parameters.AddWithValue("_wb_o", stock.WbO);
                cmd.Parameters.AddWithValue("_tc_a", stock.TcA);
                cmd.Parameters.AddWithValue("_tc_b", stock.TcB);
                cmd.Parameters.AddWithValue("_tc_ab", stock.TcAb);
                cmd.Parameters.AddWithValue("_tc_o", stock.TcO);
                cmd.Parameters.AddWithValue("_prc_a", stock.PrcA);
                cmd.Parameters.AddWithValue("_prc_b", stock.PrcB);
                cmd.Parameters.AddWithValue("_prc_ab", stock.PrcAb);
                cmd.Parameters.AddWithValue("_prc_o", stock.PrcO);

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

        public int Delete(string stockId)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from blood_stock_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", stockId);

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

        public Dictionary<string, string> Search(string region)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from blood_stock_select() where _region = '" + region + "' order by _date_stock desc limit 1";
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    data.Add("id", rd["_id"].ToString());
                    data.Add("region", rd["_region"].ToString());
                    data.Add("wb_a", rd["_wb_a"].ToString());
                    data.Add("wb_b", rd["_wb_b"].ToString());
                    data.Add("wb_ab", rd["_wb_ab"].ToString());
                    data.Add("wb_o", rd["_wb_o"].ToString());
                    data.Add("prc_a", rd["_prc_a"].ToString());
                    data.Add("prc_b", rd["_prc_b"].ToString());
                    data.Add("prc_ab", rd["_prc_ab"].ToString());
                    data.Add("prc_o", rd["_prc_o"].ToString());
                    data.Add("tc_a", rd["_tc_a"].ToString());
                    data.Add("tc_b", rd["_tc_b"].ToString());
                    data.Add("tc_ab", rd["_tc_ab"].ToString());
                    data.Add("tc_o", rd["_tc_o"].ToString());
                    data.Add("date_stock", rd["_date_stock"].ToString());
                }

                conn.Close();
                return data;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + sql, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return null;
            }
        }
    }
}
