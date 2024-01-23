using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CuaHang
{
    internal class QuanLySanPham : SanPham
    {
      
        private SanPham[] danhSachSP;
        public QuanLySanPham()
        {
            ten = "Cua Hang Ban Le";
            danhSachSP = new SanPham[10];
        }
        public void NhapMang()
        {

            Console.WriteLine("Nhap so luong San Pham");
            int n = int.Parse(Console.ReadLine());
            danhSachSP = new SanPham[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap loai san pham (Socola/NuocUong) #{i + 1}: ");
                string loaiSP = Console.ReadLine();
                if (loaiSP.ToLower() == "socola")
                {

                    danhSachSP[i] = new Socola();
                }
                else if (loaiSP.ToLower() == "nuocuong")
                {

                    danhSachSP[i] = new NuocUong();
                }
                else
                {
                    Console.WriteLine("khong hop le !!!");
                    return;

                }
                danhSachSP[i].Nhap();
            }

        }
        public override void InChiTiet()
        {
            base.InChiTiet();
           
        }
    }
}
    

