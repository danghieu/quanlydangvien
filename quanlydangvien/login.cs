using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace quanlydangvien
{
    public partial class Formquanlydangvien : Form
    {
        database db = new database();
        public Formquanlydangvien()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok= db.checklogin(textBoxtaikhoan.Text,textBoxmatkhau.Text);
            if(ok){
                this.Hide();
                formhethongquanly htql = new formhethongquanly();
                htql.Show();
            }

            
        }
    }
}
