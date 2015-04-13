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
        string image;
        public themdangvien()
        {
            InitializeComponent();
            
        }

        private void labelngoaingu_Click(object sender, EventArgs e)
        {

        }

        private void buttonbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "E:";
            open.Filter = open.Filter = "Image file|" + "*.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff; *.gif";
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(open.OpenFile());
                image = open.FileName;
            }
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            database db = new database();
            db.themdangvien(image, textBoxsothedv.Text, textBoxten.Text, dateTimePickerngaysinh.Value, 
                 comboBoxgioitinh.Text, int.Parse(textBoxcmnd.Text),dateTimePickerngayvaochinhthuc.Value, textBoxnoivaochinhthuc.Text, dateTimePickerngayvaodubi.Value, 
                    textBoxnoivaodubi.Text,textBoxquequan.Text, textBoxnoisinh.Text,  comboBoxtongiao.Text, comboBoxdantoc.Text, 
                    comboBoxtrinhdophothong.Text,textBoxsolylich.Text,textBoxbidanh.Text,textBoxnghenghiep.Text, 
                    comboBoxchibo.Text,comboBoxchucdanh.Text,comboBoxlyluanchinhtri.Text,textBoxhiennay.Text,richTextBoxthongtinthem.Text,comboBoxtrangthai.Text);
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void labelcacbidanh_Click(object sender, EventArgs e)
        {

        }
    }
}
