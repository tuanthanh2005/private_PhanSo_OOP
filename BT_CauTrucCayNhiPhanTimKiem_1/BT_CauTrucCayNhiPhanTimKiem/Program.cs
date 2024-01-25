using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_CauTrucCayNhiPhanTimKiem
{
    class TNode
    {
        public int Info;
        public TNode Left;
        public TNode Right;

        public TNode(int x)
        {
            Info = x;
            Left = null;
            Right = null;
        }
    }
    //Dinh nghia Cay Nhi Phân
    class TimKiemcayNhiPhan
    {
        public TNode Root;

        public void KtTruoc(TNode root)
        {
            if (root != null)
            {
                Console.WriteLine($"{root.Info}  -> ");
                KtTruoc(root.Left);

                KtTruoc(root.Right);
            }
        }
        public void KtGiua(TNode root)
        {
            if (root != null)
            {
                KtGiua(root.Left);
                Console.WriteLine($"{root.Info} -> ");
                KtGiua(root.Right);
            }
        }
        public void KtCuoi(TNode root)
        {
            if (root != null)
            {
                KtCuoi(root.Left);
                KtCuoi(root.Right);
                Console.WriteLine($"{root.Info} -> ");
            }
        }
        public void ThemNode(ref TNode root, int x)
        {
            if (root == null)
            {
                TNode p = new TNode(x);
                root = p;
            }
            else if (root.Info > x)
           
                ThemNode(ref root.Left, x);
          
            else if (root.Info < x)
           
                ThemNode(ref root.Right, x);
           
        }

        public void TaoCay()
        {
            Console.Write("Cho Biet So Nut:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Nhap Gia Tri Node " + i+ ":");
                int x = int.Parse(Console.ReadLine());
                ThemNode(ref Root, x);
            }
        }
        public TNode TimNutTheoKhoa(TNode root, int x)
        {
            TNode sum = null;
            if (root != null)
            {
                if (root.Info == x)

                    sum = root;
                //giá trị x(la só cha) bé hơn root se xu lý bên trái ròi xử lí bên phải
                else if (x < root.Info)

                    sum = TimNutTheoKhoa(root.Left, x);

                else
                    sum = TimNutTheoKhoa(root.Right, x);
            }
            return sum;
        }
    }
    

    
        
        internal class Program
        {
            static void Main(string[] args)
            {

                TimKiemcayNhiPhan kq = new TimKiemcayNhiPhan();
                kq.TaoCay();
               Console.WriteLine("Ket Qua Can Duyet Cay");

               Console.WriteLine("\n Truoc");
               kq.KtTruoc(kq.Root);

               Console.WriteLine("\n Giua");
               kq.KtGiua(kq.Root);

               Console.WriteLine("\n Cuoi");
               kq.KtCuoi(kq.Root);
            //tim nut theo khoa
            Console.WriteLine("Nhap Gia tri can tim");
            int x = int.Parse(Console.ReadLine());
            TNode kq2= kq.TimNutTheoKhoa(kq.Root,x);
            if (kq2==null)
            {
                Console.WriteLine($"{x} khong xuat hien trong cay");
            }
            else
            {
                Console.WriteLine($"{x} co xuat hien trong cay");
            }
            Console.ReadLine();
        }
      }
  }

