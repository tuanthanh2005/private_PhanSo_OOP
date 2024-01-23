using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Stack_OOP_1
{
    class Stack
    {
        private int[] data;
        private int top;



        public Stack()
        {
            data = new int[10];
            top = -1;
        }
        public Stack(int size)
        {
            data = new int[size];
            top = -1;
        }
        public bool isEmpty()
        {
            bool Kq = false;
            if (top == -1)

                Kq = true;


            return Kq;

        }
        public bool isFull()
        {
            bool kq1 = false;
            // kiem tra data có size ful chưa
            // chua full thì true
            if (top == data.Length - 1)

                kq1 = true;

            return kq1;
        }

        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("them that bai ");
            }
            else
            {
                //top ++;
                //data[top] = x;
                data[++top] = x;
            }

        }
        public int Pop()
        {

            if (isEmpty())
            {
                Console.WriteLine("them fals");
            }

            //top --;
            // kq = data[top--];
            int kq = data[top--];

            return kq;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int n, h;
            Console.Write(" nhap co so 10 : ");
            n = int.Parse(Console.ReadLine());
            Console.Write(" Nhap he (2,8,16) : ");
            h = int.Parse(Console.ReadLine());
            Stack s = new Stack();

            while (n > 0)
            {
                s.Push(n % h);// lấy dư
                n = n / h; // lấy nguyên
            }
            int giatri;
            Console.Write($" bieu dien he {h}: ");
            while (!s.isEmpty())
            {
                giatri = s.Pop();
                if (h == 16)


                    switch (giatri)
                    {
                        case 10:
                            Console.WriteLine("A");
                            break;
                        case 11:
                            Console.WriteLine("B");
                            break;
                        case 12:
                            Console.WriteLine("C");
                            break;
                        case 13:
                            Console.WriteLine("D");
                            break;
                        case 14:
                            Console.WriteLine("E");
                            break;
                        case 15:
                            Console.WriteLine("F");
                            break;

                        default:
                            Console.Write(giatri);
                            break;

                    }
                else// cac co so 2,8

                    Console.Write(giatri);




            }

            s.Push(1);
            s.Push(2);
            s.Push(3);


            // pop ra dat dk

            //if (s.isEmpty())
            //{
            //    Console.WriteLine("rong");
            //}
            //else
            //{
            //    Console.WriteLine(" ko rong");
            //}
            int x = s.Pop();
            Console.Write(" \n Phan tu Duoc Lay ra là {0}", x);


            //if (s.isEmpty())
            //{
            //    Console.WriteLine("Ngăn Xếp Đầy");
            //}
            //else
            //{
            //    Console.WriteLine(" ngan xep khong Đầy");
            //}
            Console.ReadLine();
        }
    }
}

