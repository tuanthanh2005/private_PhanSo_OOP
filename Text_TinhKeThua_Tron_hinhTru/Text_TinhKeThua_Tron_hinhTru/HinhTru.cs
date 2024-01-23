using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_TinhKeThua_Tron_hinhTru
{
    internal class HinhTru:HinhTron
    {
        private double chieuCao;

       
        public HinhTru() : base()
        {
            chieuCao = 5;
        }
        public HinhTru(double chieuCao, double banKinh) : base(banKinh)
        {
            this.chieuCao = chieuCao;
        }

        public void setChieuCao(double chieuCao)
        {
            this.chieuCao= chieuCao;
        }
        public double getChieuCao()
        {
           return chieuCao;             
        }
        public new double TinhDienTich()
        {
            return 2*base.TinhDienTich()+TinhChuVi()*chieuCao;
        }
        public double TinhTheTich()
        {
            return base.TinhDienTich()*chieuCao;
        }

       
    }
}
