using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace quanlydangvien
{
    class database
    {
        private string conn;
        private MySqlConnection connect;
        MySqlCommand cmdDb;
        MySqlDataAdapter sda;
        MySqlDataReader dr;

        void db_connection(){
            try
            {
                conn = "Server=localhost;Database=quanlydangvien;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        public bool checklogin(string taikhoan, string matkhau)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from users where taikhoan=@taikhoan and matkhau=@matkhau";
            cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
    }

}
