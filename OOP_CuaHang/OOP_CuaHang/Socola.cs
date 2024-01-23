using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CuaHang
{
    internal class Socola : SanPham
    {
        private double loiNhuan;


        public Socola() :base()
        {
            loiNhuan = GiaMua * 0.2;
        }
        public Socola(string ten , double giaMua) : base(ten, giaMua)
        {
            loiNhuan = giaMua * 0.2;
        }
        public override double TinhGiaBan()
        {
            return  GiaMua + loiNhuan;
        }
        public override void InChiTiet()
        {
          base.InChiTiet();
            Console.WriteLine("Lợi nhuận: {0}", loiNhuan);
            
            
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Lợi nhuận: ");
            loiNhuan = Convert.ToDouble(Console.ReadLine());
        }


    }
}
