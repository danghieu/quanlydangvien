using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydangvien
{
    public partial class themdangvien : Form
    {
        public themdangvien()
        {
            InitializeComponent();
            database db = new database();
        }

        private void labelngoaingu_Click(object sender, EventArgs e)
        {

        }

        private void buttonbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "E:";
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(open.OpenFile());
            }
        }
    }
}
