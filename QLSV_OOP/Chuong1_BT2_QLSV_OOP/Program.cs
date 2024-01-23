using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//Viết chương trình OOP quản lý sinh viên đơn giản: Nhập, xuất thông tin, tính điểm TB.
//- Viết lớp Sinh viên như sau:
//Attributes(private):
//▪ Mã sinh viên là số nguyên.
//▪ Họ tên: chuỗi ký tự.
//▪ Điểm LT, điểm TH : float
//Constructor:
//▪ Constructor mặc định (để khởi tạo đối tượng với các thông tin kiểu số là 0, kiểu chuỗi là
//chuỗi rỗng).
//▪ Constructor thứ hai nhận đầy đủ thông tin để khởi tạo giá trị cho tất cả các biến instance.
namespace Chuong1_BT2_QLSV_OOP
{
    class QLSV
    {
        private int MaSV;
        private string HoTenSV;
        private float DiemLT;
        private float DiemTH;

        public QLSV(int MaSV , String HoTenSV, float DiemLT, float DiemTH)
        {
            MaSV = 0;
            HoTenSV = "";
            DiemLT = 0;
            DiemLT= 0;
        }
        public int getMaSV()
        {
            return MaSV;
        }
        public void setMaSV(int MaSV)
        {
            this.MaSV = MaSV;
        }
        public string getHoTen()
        {
            return HoTenSV;
        }
        public string HoTen
        {
            get { return HoTenSV; }
            set {HoTenSV = value; }
        }


        public int getMaSV()
        {
            return MaSV;
        }
        public void setMaSV(int MaSV)
        {
            this.MaSV = MaSV;
        }

        public int getMaSV()
        {
            return MaSV;
        }
        public void setMaSV(int MaSV)
        {
            this.MaSV = MaSV;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
