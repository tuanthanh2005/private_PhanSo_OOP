using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyThuVien_sach
{
    internal class Sach:QuanLyTaiLieu
    {
        private string tenTacGia;
        private int soTrang;


        public Sach()
        {

        }
        public Sach ( string tenTacGia,int soTrang,int maTaiLieu,string tenXuatBan,int soBanPhatHanh):base(maTaiLieu,tenXuatBan,soBanPhatHanh) 
        {
            this.tenTacGia = tenTacGia;
            this.soTrang = soTrang;
        }


        public string TenTacGia
        {
            set { tenTacGia = value; }
            get { return tenTacGia; }
        }
        public int SoTrang
        {
            set { soTrang = value; }
            get { return soTrang; }
        }



    }
}
