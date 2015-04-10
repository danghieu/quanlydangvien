using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
namespace quanlydangvien
{
    class database
    {
        private string conn;
        private SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlDataReader dr;

        void db_connection(){
            try
            {
                conn = "Data Source=DANGHIEU-PC;Initial Catalog=quanlydangvien;Integrated Security=True";
                connect = new SqlConnection(conn);
                connect.Open();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public user checklogin(string taikhoan, string matkhau)
        {
            user curuser = null;
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "Select taikhoan,matkhau,hoten,capdo from users where taikhoan=@taikhoan and matkhau=@matkhau";
            cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Connection = connect;
            SqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {


                string tk = login.GetString(0);
                string mk = login.GetString(1);
                string ht = login.GetString(2);
                int cd = login.GetInt32(3);
                curuser = new user(tk, mk, ht, cd);
               // connect.Close();
            }
            return curuser;
        }
    }

}
