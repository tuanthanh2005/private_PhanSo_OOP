using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class PhanSo
    {
        private int TuSo;
        private int MauSo;


        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }
        public PhanSo(int TuSo, int MauSo)
        {
            this.TuSo = TuSo;
            this.MauSo = MauSo;
        }
        public void setTuSo(int TuSo)
        {
            this.TuSo = TuSo;
        }
        public int getTuSo()
        {
            return TuSo;
        }
        public void setMauSo(int MauSo)
        {
            this.MauSo = MauSo;
        }
        public int getMauSo()
        {
            return MauSo;
        }
        public void ToiGian()
        {

            int usc = TimUSC(TuSo, MauSo);
            TuSo = TuSo / usc;
            MauSo = MauSo / usc;
        }

        private int TimUSC(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                    y = y - x;
            }
            return x;
        }
        public PhanSo Cong(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = TuSo * ps.MauSo + ps.TuSo * MauSo;
            kq.MauSo = MauSo * ps.MauSo;
            return kq;
        }
        public PhanSo Tru(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = TuSo * ps.MauSo - ps.MauSo * TuSo;
            kq.MauSo = MauSo * ps.MauSo;
            return kq;
        }
        public PhanSo Nhan(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = TuSo * ps.TuSo;
            kq.MauSo = MauSo * ps.MauSo;
            return kq;
        }
        public PhanSo Chia(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = TuSo * ps.MauSo;
            kq.MauSo = MauSo * ps.TuSo;
            return kq;
        }




    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap Tu So: ");
            int TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Mau So: ");
            int MauSo = int.Parse(Console.ReadLine());
            PhanSo S1 = new PhanSo(TuSo, MauSo);
            S1.setTuSo(TuSo);
            S1.setMauSo(MauSo);


            Console.WriteLine("Nhap Tu So 2: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Mau So 2: ");
            MauSo = int.Parse(Console.ReadLine());
            PhanSo S2 = new PhanSo(TuSo, MauSo);
            S2.setTuSo(TuSo);
            S2.setMauSo(MauSo);


            PhanSo Tong = S1.Cong(S2);

            Tong.ToiGian();

            Console.WriteLine(" Xuat ket Qua [{0}/{1}] + [{2}/{3}] = [{4}/{5}]"
                , S1.getTuSo(), S1.getMauSo(), S2.getTuSo(), S2.getMauSo(), Tong.getTuSo(), Tong.getMauSo());
            // câu 2




            int n;
            Console.WriteLine(" Nhập N:  ");
            n = Convert.ToInt32(Console.ReadLine());
            double tong = 0;

            for (int i = 1; i <= n; i++)
            {
                tong += 1.0 / i;
            }
            Console.WriteLine(" Tổng Dãy Số Của Phân Số Là ={0}", tong);






            Console.ReadLine();




        }
    }
}