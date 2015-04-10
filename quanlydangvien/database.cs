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
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        MySqlDataReader dr;

        void db_connection(){
            try
            {
                conn = "Server=localhost;Database=quanlydangvien;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException )
            {
                throw;
            }
        }
        public user checklogin(string taikhoan, string matkhau)
        {
            user curuser = null;
            db_connection();
            cmd = new MySqlCommand();
            cmd.CommandText = "Select taikhoan,matkhau,hoten,capdo from users where taikhoan=@taikhoan and matkhau=@matkhau";
            cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {


                string tk = login.GetString("taikhoan");
                string mk = login.GetString("matkhau");
                string ht = login.GetString("hoten");
                int cd = login.GetInt32("capdo");
                curuser = new user(tk, mk, ht, cd);
                connect.Close();
            }
            return curuser;
        }
    }

}
