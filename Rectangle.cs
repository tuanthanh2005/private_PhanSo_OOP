using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Viết chương trình tính diện tích, chu vi hình chữ nhật.
//- Hãy viết lớp HinhChuNhat gồm có:
//▪ Thuộc tính : chiều dài, chiều rộng.
//▪ Phương thức thiết lập (set), và lấy(get) thông tin chiều dài, chiều rộng.
//▪ Phương thức tính diện tích, chu vi.
//▪ Phương thức toString gồm các thông tin dài, rộng, diện tích, chu vi.
//- Xây dựng lớp chứa hàm main cho phần kiểm nghiệm. Dài rộng có thể nhập từ bàn phím.

namespace Chuong1_BT03_OOP
{
    class Rectangle
    {
        private int length;
        private int width;
        public Rectangle()
        {
        }

        public Rectangle ( int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int getlength()
        {
            return length;
        }
        public void setlength( int length )
        {
            this.length = length;
        }
        public int getWidth()
        {
            return width;
        }
        public void setwidth( int width )
        {
            this.width = width;
        }

        public int TinhChuVi()
        {
            return (length + width) *   2;
        }
        public int TinhDienTich()
        {
            return length * width;
        }
        public override string ToString()
        {
            return "chieu dai " + length + "chieu rong" + width + "dien tich" + TinhDienTich() + "chu vi" + TinhChuVi();
        }





    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập chiều dài: ");
          int length = int .Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng: ");
           int width = int.Parse(Console.ReadLine());

            Rectangle HCN = new Rectangle(length, width);
            Console.WriteLine(HCN);
            Console.ReadLine();
        }
    }
}
