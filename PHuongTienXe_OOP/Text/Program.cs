using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class Vehicle
    {
        private string maxe;
        private int giaxe;
        private int dungtich;


        public Vehicle(string maxe ,int giaxe, int dungtich) 
        {
            this.maxe = maxe;
            this.giaxe=giaxe;
            this.dungtich=dungtich;
        }
        public string MaXe
        {
            get { return maxe; }
        }
        public int GiaXe
        {
            get { return giaxe; }

        }
        public int Dungtich
        {
            get { return dungtich; }
        }


        public double TinhThue()
        {
            if (dungtich < 100)
            {
                return giaxe * 0.01;
            }
            else if (dungtich >= 100 && dungtich <= 200)
            {
                return giaxe * 0.03;
            }
            else
                return giaxe * 0.05;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle xe1 = new Vehicle("Tuan", 100, 100);
            Console.WriteLine($"|  {xe1.MaXe,-6}  |  {xe1.GiaXe,-14:C}  |  {xe1.Dungtich,-10}  |  {xe1.TinhThue(),-12:C}  |");
            Console.ReadKey();
        }
    }
}
