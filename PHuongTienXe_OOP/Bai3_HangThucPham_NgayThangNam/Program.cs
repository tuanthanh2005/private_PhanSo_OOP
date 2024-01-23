using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_HangThucPham_NgayThangNam
{
    internal class Program
    {
        class HangThucPham {
            private string maHang;
            private string tenHang;
            private double donGia;
            DateTime ngaysanxuat;
            DateTime ngayhethan;


            public HangThucPham(string maHang , string tenHang, double donGia, DateTime ngaysanxuat, DateTime ngayhethan)
            {
                this.maHang = maHang;
                this.tenHang = tenHang;
                this.donGia = donGia;
                this.ngayhethan = ngayhethan;
                this.ngaysanxuat = ngaysanxuat;
               
            }
            public HangThucPham(string maHang)
            {
                this.maHang = maHang;
            }
            public string MaHang
            {
                set { maHang = value; }
                get { return maHang; }
            }
            public string TenHang
            {
                set { tenHang = value; }
                get { return tenHang; }
            }
            public double DonGia
            {
                set { donGia = value; }
                get { return donGia; }
            }
            public DateTime NgaySanXuat
            {
                set { ngaysanxuat = value; }
                get { return ngaysanxuat; }
            }
            public DateTime NgayHetHan
            {
                set
                {
                    int kq = DateTime.Compare(ngaysanxuat, value);
                    if (kq < 0)

                        ngayhethan = value;


                    else
                        ngayhethan = ngaysanxuat;
                }
                get { return ngayhethan; }
            }
             

            public bool kiemTraHang()
            {
                DateTime ngayhienhanh= DateTime.Today;
                int kq = DateTime.Compare(ngayhethan, ngayhienhanh);
                if (kq < 0)
                    return true;
                return false;
            }


        }
        static void Main(string[] args)
        {
            string maHang = "SP1";
            string tenHang = "Beer";
            double donGia = 1000000;
            DateTime ngaysanxuat = DateTime.Parse("01/10/2023");
            DateTime ngayhethan = DateTime.Parse("01/03/2023");
            HangThucPham thucPham1 = new HangThucPham(maHang,tenHang,donGia,ngaysanxuat,ngayhethan);
           
            
            Console.WriteLine("MaHang:{0} - TenHang{1} - Don Gia{2} - Ngay San xuat{3:dd/MM/yyyy} - Ngay Het Han{4:dd/MM/yyyy} "
                ,thucPham1.MaHang, thucPham1.TenHang ,thucPham1.DonGia  ,thucPham1.NgaySanXuat ,thucPham1.NgayHetHan);
            if (thucPham1.kiemTraHang())
            {
                Console.WriteLine( " San Pham con Han ");
            }else
                Console.WriteLine("San Pham dã het Han");
            Console.ReadLine();
        }
    }
}
