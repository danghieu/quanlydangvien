using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlydangvien
{
    class user
    {
        private string taikhoan;
        private string matkhau;
        private string hoten;
        private int capdo;

        
        public string Taikhoan
        {
            get
            {
                return taikhoan;
            }
            set
            {
                taikhoan = value;
            }
        }
        public string Matkhau
        {
            get
            {
                return matkhau;
            }
            set
            {
                matkhau = value;
            }
        }
        public string Hoten
        {
            get
            {
                return hoten;
            }
            set
            {
                hoten = value;
            }
        }
        public int Capdo
        {
            get
            {
                return capdo;
            }
            set
            {
                capdo = value;
            }
        }
        public user(string tk, string mk, string ht, int cd)
        {
            taikhoan = tk;
            matkhau = mk;
            hoten = ht;
            capdo = cd;
        }
    }

}
