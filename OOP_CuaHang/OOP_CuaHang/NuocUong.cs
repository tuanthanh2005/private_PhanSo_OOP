using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CuaHang
{
    internal class NuocUong :SanPham
    {
        private double loiNhuan;
        private double chiPhiGiuLanh;



        public NuocUong() : base()
        {
            loiNhuan = GiaMua * 0.15;
            chiPhiGiuLanh = GiaMua * 0.1;
        }
        public NuocUong(string ten, double giaMua) : base(ten,giaMua)
        {
            loiNhuan = GiaMua * 0.15;
            chiPhiGiuLanh = GiaMua * 0.1;
        }

        public override double TinhGiaBan()
        {
            return GiaMua +loiNhuan +chiPhiGiuLanh;
        }
        public override void InChiTiet()
        {
             base.InChiTiet();
        Console.WriteLine("Lợi nhuận: {0}", loiNhuan);
            Console.WriteLine("Chi phí giữ lạnh: {0}", chiPhiGiuLanh);
         
            
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Lợi nhuận: ");
            loiNhuan = Convert.ToDouble(Console.ReadLine());
        }

    }
    
}
