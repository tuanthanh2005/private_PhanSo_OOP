using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CuaHang
{
    internal class SanPham
    {

        protected string ten;
        protected double giaMua;

        
        public string Ten
        {
            set {  ten = value; }        
     
            get { return ten; }
        }
        public double GiaMua
        {
            set {
                if (value >= 0)
                {
                    giaMua = value;
                }else
                Console.WriteLine("Gia Tien phai lon Hon 0");
                
                
                
                }
            get  { return giaMua; }
        }

        public SanPham() :base() { } 
        public SanPham(string ten ,double giaMua)
        { 
            this.ten = ten;
            this.giaMua= giaMua;
        }
        public virtual double TinhGiaBan()
        {
            return 0;
        }
        public virtual void InChiTiet()
        {
            Console.WriteLine("Ten san pham {0}",ten);
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập tên sản phẩm: ");
            ten = Console.ReadLine();
            Console.Write("Nhập giá mua sản phẩm: ");
            giaMua = Convert.ToDouble(Console.ReadLine());
        }
    }
}
