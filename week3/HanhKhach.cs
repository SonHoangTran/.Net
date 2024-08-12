using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week3
{
    internal class HanhKhach : ConNguoi
    {
        Vemaybay ve;
        int soLuong;

        public HanhKhach(string hoTen, string gioiTinh, int tuoi, Vemaybay ve, int soLuong) : base(hoTen, gioiTinh, tuoi)
        {
            this.ve = ve;
            this.soLuong = soLuong;
        }

        public int SoLuong { get => soLuong; set => soLuong = value; }
        internal Vemaybay Ve { get => ve; set => ve = value; }

        public double tongTien()
        {
            double result = ve.GiaVe * soLuong;
            if (ve.NgayGioBay.Month == 10)
            {
                result *=  0.9;
            }
            return result;
        }
    }
}
