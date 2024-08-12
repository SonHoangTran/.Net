using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week3
{
    internal class Vemaybay
    {
        String tenChuyen;
        DateTime ngayGioBay;
        double giaVe;

        public Vemaybay(string tenChuyen, DateTime ngayGioBay, double giaVe)
        {
            this.TenChuyen = tenChuyen;
            this.NgayGioBay = ngayGioBay;
            this.GiaVe = giaVe;
        }

        public string TenChuyen { get => tenChuyen; set => tenChuyen = value; }
      
        public double GiaVe { get => giaVe; set => giaVe = value; }
        public DateTime NgayGioBay { get => ngayGioBay; set => ngayGioBay = value; }
    }
}
