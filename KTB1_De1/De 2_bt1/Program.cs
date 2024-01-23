using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_2_bt1
{
    class SinhVien
    {
        private string hoTen;
           private char khoiHoc;
        private double diemToan, diemVan, diemNgoaiNgu;

        public SinhVien()
        {
            hoTen = "thanh tuan";
            khoiHoc = 'A';
            diemNgoaiNgu = 8;
            diemToan = 9;
            diemVan =10;
        }
        public SinhVien(string hoTen, char khoiHoc, double diemToan, double diemVan, double diemNgoaiNgu)
        {
            this.hoTen = hoTen;
            this.khoiHoc = khoiHoc;
            this.diemVan = diemVan;
            this.diemToan = diemToan;
            this.diemNgoaiNgu = diemNgoaiNgu;
        }
        public string HoTen
        {
            set { hoTen = value; }
            get { return hoTen; }



        }
        public char KhoiHoc
        {
            set { khoiHoc = value; }
            get { return khoiHoc; }
        }
        public double DiemVan
        {
            set { diemVan = value; }
            get { return diemVan; }
        }
        public double DiemToan
        {
            set { diemToan = value; }
            get { return diemToan; }
        }
        public double DiemNgoaiNgu
        {
            set { diemNgoaiNgu = value; }
            get { return diemNgoaiNgu; }
        }
        public double TinhTrungBinh()
        {
            double tinhtb=0;
         switch(khoiHoc)
            {
                case 'A': 
                    tinhtb = (diemNgoaiNgu + (diemToan * 2) + diemVan ) / 4;
                    break;
                case 'D':
                    tinhtb = ((diemNgoaiNgu*2) + diemToan + diemVan) / 4;
                    break;
                case 'C':
                    tinhtb = (diemNgoaiNgu + diemToan + (diemVan*2)) / 4;
                    break;
            } 
            return tinhtb;

        }
        public string TinhXepLoai()
        {
            string xeploai ;
            if (TinhTrungBinh() >= 5)
            {
                xeploai = "Duoc Len Lop";
            }
            else
            {
                xeploai = "Lưu ban";
            }
            return xeploai;

        }
        public void InThongTin()
        {
            Console.WriteLine ("Họ tên: " + hoTen);
            Console.WriteLine("Điểm trung bình: " + TinhTrungBinh());
            Console.WriteLine ("Xếp loại: " + TinhXepLoai());

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                SinhVien sv=new SinhVien();
                sv.TinhTrungBinh();
                sv.TinhXepLoai();
                sv.InThongTin();
                Console.ReadLine();
            }
        }
    }
}
