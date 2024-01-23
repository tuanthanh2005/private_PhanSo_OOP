using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyThuVien_sach
{
    internal class QuanLyTaiLieu
    {
        private int maTaiLieu;
        private string tenXuatBan;
        private int soBanPhatHanh;

        public QuanLyTaiLieu() : base()
        {

        }
       public QuanLyTaiLieu (int maTaiLieu,string tenXuatBan,int soBanPhatHanh)
        {
            this.maTaiLieu = maTaiLieu;
            this.tenXuatBan = tenXuatBan;
            this.soBanPhatHanh = soBanPhatHanh;
        }
        public int MaTaiLieu
        {
            set { maTaiLieu = value; }
            get { return maTaiLieu; }
        }
        public string TenXuatBan
        {
            set { tenXuatBan = value; }
            get { return tenXuatBan; }
        }
        public int SoBanPhatHanh
        {
            set { soBanPhatHanh = value; }
            get { return soBanPhatHanh; }
        }
    }
}
