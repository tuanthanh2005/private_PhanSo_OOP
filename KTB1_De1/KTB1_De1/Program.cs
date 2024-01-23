using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTB1_De1
{
    class NhanVien
    {
        private string hoTen;
        private int soNgayCong;
        private int soNgayLamThem;
        private char xepLoai;
        private string boPhan;


        public NhanVien() {
            hoTen = "Thanh Tuan";
            soNgayCong = 10;
            soNgayLamThem = 15;
            xepLoai = 'A';
            boPhan = "Truc Tiep";
                }
        public NhanVien(string hoTen, int soNgayCong, int soNgayLamThem, char xepLoai, string boPhan)
        {
            this.hoTen = hoTen;
            this.boPhan = boPhan;
            this.soNgayLamThem = soNgayLamThem;
            this.soNgayCong = soNgayCong;
            this.xepLoai = xepLoai;


        }
        public string HoTen
        {
            set { hoTen = value; }
                get{ return hoTen; }
        } 
        public int SoNgayCong
        {
            set { soNgayCong = value; }
                get{ return soNgayCong; }
        }
        public int SoNgayLamThem
        {
            set { soNgayLamThem = value; }
                get{ return soNgayLamThem; }
        }
        public char XepLoai
        {
            set {xepLoai = value; }
            get { return xepLoai; }
        }
        public string BoPhan
        {
            set { boPhan = value; }
            get { return boPhan; }
        }

        public int TinhLuong()
        {
            int Luong;
            if (boPhan.Equals("Truc Tiep"))
            {
                soNgayLamThem = soNgayLamThem * 3;
            }
            else if (boPhan.Equals("gian Tiep"))
            {
                soNgayLamThem = soNgayLamThem * 2;
            }
            Luong= (soNgayCong + soNgayLamThem) * 100000;
            return Luong;
        }
        public int TinhThuNhap()
        {
            int sum = 0;
            switch (xepLoai)
            {
                case 'A':
                    sum = TinhLuong() * 150 / 100;
                    break;
                case 'B':
                    sum = TinhLuong() * 120 / 100;
                    break;
                case 'C':
                    sum = TinhLuong();
                    break;


            }
            return sum;
        }
           public void InThongTin()
        {
            Console.WriteLine("Họ tên: {0}",hoTen );
                Console.WriteLine("Bộ phận: {0}" , boPhan);
            Console.WriteLine("Tinh Luong :{0} ", TinhLuong());
            Console.WriteLine("Thu nhập:{0} ",  TinhThuNhap());
          
        }

    }



    
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv=new NhanVien();
            nv.TinhLuong();
            nv.TinhThuNhap();
            nv.InThongTin();
            Console.ReadLine();
        }
    }
}
