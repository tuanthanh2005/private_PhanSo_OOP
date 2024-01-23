using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLK_BT2
{
    class Node
    {
        private int info;
        private Node next;



        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int Info
        {
            set { info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { next = value; }
            get { return next; }
        }
        class DSLKD
        {
            private Node head;




            public DSLKD()
            {
                head = null;
            }
            public void ThemNutDauVao(int x)
            {
                Node No = new Node(x);
                
                No.next = head;
                head = No;
                
            }
            public void XuatDS()
            {
                Node Xuat = head;
                while (Xuat != null)
                {
                   
                    Console.Write($"\n{Xuat.info}");
                    Xuat = Xuat.next;
                }
               Console.WriteLine();
            }

            public Node TimNutCaoNhat()
            {
                Node MaxLon = head;
                Node NutDau=head;
                while (NutDau != null)
                {
                    if (NutDau.info >MaxLon.info)
                    {
                       MaxLon = NutDau;
                    }
                    NutDau = NutDau.next;
                }
                return MaxLon;
            }
            public double TinhTB()
            {
                double SumAllSo = 0;
                double SoDem = 0;
                Node NutDau= head;
                while (NutDau != null)
                {
                    SumAllSo=SumAllSo+NutDau.info;
                    SoDem++;
                    NutDau=NutDau.next;
                }
                return SumAllSo / SoDem;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                int x = 0;
                DSLKD XTT = new DSLKD();
                Console.WriteLine("Nhập Giá trị Nút: ");
              
                do
                {
                    if (int.TryParse(Console.ReadLine(), out x) && x != 0)
                    {

                        XTT.ThemNutDauVao(x);
                    }
                    else
                    {
                        break;
                    }
                } while (true);


                    Console.WriteLine("Xuat Danh Sach");             
                //XTT.ThemNutDauVao(3);
                //XTT.ThemNutDauVao(9);
                //XTT.ThemNutDauVao(7);

                XTT.XuatDS();
                Node MaxLon = XTT.TimNutCaoNhat();
                Console.WriteLine(" Giá Trị Lơn Nhất Là {0}",MaxLon.info);

                Console.WriteLine("Xuat KQ Tinh Trung Binh {0}",XTT.TinhTB());
               
                Console.ReadLine();

            }
        }
    }
}
