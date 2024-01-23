using Chuong1_SinhVien_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_SinhVien_OOP
{
    class SinhVien
    {
        private int maSV;
        private string hoTen;
        private string diaChi;
        private string soDT;


        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        public SinhVien(int maSV, string hoTen, string diaChi, string soDT)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDT = soDT;
        }
        public override string ToString()
        {
            return $"{maSV}-{hoTen}-{diaChi}-{soDT}";
        } 
       











        class QuanLySinhVien
        {
            static void Main()
            {
                SinhVien S1 = new SinhVien(11, "TranThanhTuan", "apTanPhuxaanNhon", "0125455524552");

                SinhVien S2 = new SinhVien(15, "TranThanh", "apTanPhuxaanNhon", "0125424552");
                Console.WriteLine(S1);
                Console.WriteLine(S2);

                Console.Write("Nhập số lượng sinh viên: ");
                int n = int.Parse(Console.ReadLine());

                SinhVien[] danhSachSinhVien = new SinhVien[n];

                // Nhập thông tin cho từng sinh viên
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");
                    Console.Write("Mã sinh viên: ");
                    int maSv = int.Parse(Console.ReadLine());

                    Console.Write("Họ tên: ");
                    string ten = Console.ReadLine();

                    Console.Write("Địa chỉ: ");
                    string diaChi = Console.ReadLine();

                    Console.Write("Số điện thoại: ");
                    string sdt = Console.ReadLine();

                    danhSachSinhVien[i] = new SinhVien(maSv, ten, diaChi, sdt);
                }
           
                Console.ReadKey();
                //// Sắp xếp danh sách theo mã sinh viên
                //Array.Sort(danhSachSinhVien, (sv1, sv2) => sv1.MaSinhVien.CompareTo(sv2.MaSinhVien));

                //// Xuất danh sách sinh viên
                //Console.WriteLine("\nDanh sách sinh viên sau khi sắp xếp:");
                //foreach (SinhVien sv in danhSachSinhVien)
                //{
                //    Console.WriteLine(sv.ToString());
                //}
            }

        }
    }
}
