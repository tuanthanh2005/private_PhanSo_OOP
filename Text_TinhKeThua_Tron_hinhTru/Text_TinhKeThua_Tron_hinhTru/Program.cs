using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_TinhKeThua_Tron_hinhTru
{
    class HinhTron
    {
        private double banKinh;

       
        public HinhTron():base()
        {
            banKinh = 5;
        }
        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }

        public void setBanKinh(double banKinh)
        {
            this.banKinh = banKinh;   
        }
        public double getBanKinh()
        {
            return banKinh;
        }
        public double TinhDienTich()
        {
            return Math.PI * banKinh * banKinh;
        }
        public double TinhChuVi()
        {
            return Math.PI * 2 * banKinh;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            HinhTron Htr=new HinhTron();
            Console.WriteLine("Dien Tich:{0}- Chu Vi:{1}",Htr.TinhDienTich(),Htr.TinhChuVi());
            HinhTru HTru = new HinhTru();
            Console.WriteLine("Dien Tich:{0}- The Tich:{1}", HTru.TinhDienTich(), HTru.TinhTheTich());
            Console.ReadKey();
        }
    }
}
