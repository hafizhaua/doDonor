using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace doDonor.Models
{
    internal class DbSchedule
    {
        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=dodonor";
        private static NpgsqlCommand cmd;
        private string sql = null;


        public int Create(Schedule sch)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from schedule_insert(:_region, :_date_event, :_location, :_address)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_region", sch.Region);
                cmd.Parameters.Add(new NpgsqlParameter("_date_event", NpgsqlTypes.NpgsqlDbType.Date)).Value = sch.DateEvent;
                cmd.Parameters.AddWithValue("_location", sch.Location);
                cmd.Parameters.AddWithValue("_address", sch.Address);

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

        public int Delete(string reqId)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from schedule_delete(:_id)";
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

        public List<Schedule> ReadSchedule(string region)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                string cond = region == "Semua" ? "true" : $"_region = '{region}'";
                conn.Open();
                sql = @"select * from schedule_select() where " + cond;
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();

                List<Schedule> sch_list = new List<Schedule>();

                while (rd.Read())
                {
                    Schedule sch = new Schedule(
                        rd["_id"].ToString(),
                        rd["_region"].ToString(),
                        Convert.ToDateTime(rd["_date_event"]),
                        rd["_location"].ToString(),
                        rd["_address"].ToString()
                    );

                    sch_list.Add(sch);
                }

                conn.Close();
                return sch_list;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return null;
            }


        }
    }

}
