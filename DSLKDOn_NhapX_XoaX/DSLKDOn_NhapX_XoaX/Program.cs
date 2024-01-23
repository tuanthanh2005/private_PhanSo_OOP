using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLKDOn_NhapX_XoaX
{
    class Node
    {
        private int inFo;
        private Node next;

        public Node(int x)
        {
            inFo = x;
            next = null;
        }
        public int InFo
        {
            set { inFo = value; }
            get { return inFo; }
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
            public void ThemDau(int x)
            {
                Node q = new Node(x);

                q.Next = head;
                head = q;
            }
            public void ThemCuiDS(int x)
            {
                Node p = new Node(x);

               
                    if (head == null)
                    {
                        head = p;
                    }
                    else
                    {
                        Node q = head;
                        while (q.next != null)
                        {
                            q = q.next;
                        }
                        q.next = p;
                    }
                }

            
        
            public void Xuat()
            {
                Node p = head;
                while (p != null)
                {
                    Console.WriteLine($"{p.inFo}\t");
                    p = p.Next;
                }
            }
            public void XoaGiaTri()
            {
                if (head==null)
                {
                    return;
                }

            }

            internal class Program
            {
                static void Main(string[] args)
                {
                    DSLKD dsl = new DSLKD();
                    dsl.ThemDau(1);
                    dsl.ThemDau(7);
                    dsl.ThemCuiDS(8);
                    dsl.ThemCuiDS(5);
                    dsl.Xuat();
                    Console.ReadLine();
                }
            }
        }
    }
}
