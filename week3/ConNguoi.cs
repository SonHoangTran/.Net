using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week3
{
    class ConNguoi
    {
       protected String hoTen;
       protected String gioiTinh;
       protected int tuoi;

        public ConNguoi(string hoTen, string gioiTinh, int tuoi)
        {
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.Tuoi = tuoi;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
    }
}
