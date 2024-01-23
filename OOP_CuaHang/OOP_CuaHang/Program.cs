using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CuaHang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLySanPham quanlySP=new QuanLySanPham();
            quanlySP.Nhap();
            quanlySP.InChiTiet();

            Console.ReadLine();
        }
    }
}
