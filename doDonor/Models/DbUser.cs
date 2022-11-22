using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal class DbUser
    {
        private NpgsqlConnection conn;
        private string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=dodonor";
        private static NpgsqlCommand cmd;
        private string sql = null;

        public Boolean AdminLogin(string username, string password)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"SELECT EXISTS(SELECT 1 FROM admin_acc WHERE username = :_username AND password = :_password);";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", username);
                cmd.Parameters.AddWithValue("_password", password);
                Boolean status = (Boolean)cmd.ExecuteScalar();
                conn.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return false;
            }
        }
    }
}
