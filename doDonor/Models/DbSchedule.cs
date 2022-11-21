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
        

       
        public List<Schedule> ReadSchedule()
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from schedule_select()";
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();

                List<Schedule> sch_list = new List<Schedule>();

                while (rd.Read())
                {
                    Schedule sch = new Schedule(
                    Convert.ToInt32(rd["idSchedule"]),
                    rd["region"].ToString(),
                    Convert.ToDateTime(rd["dateEvent"]),
                    rd["location"].ToString(),
                    rd["address"].ToString());

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
