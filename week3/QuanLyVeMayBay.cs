using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week3
{
    internal class QuanLyVeMayBay
    {
        public static void Main(string[] args)
        {
            List<HanhKhach> dsHanhKhach= new List<HanhKhach>();
            Console.WriteLine("Nhap so luong khach hang: ");
            int num= int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Nhap ten khach hang thu {i+1}: ");
                String hoTen= Console.ReadLine();

                Console.WriteLine($"Nhap gioi tinh khach hang thu {i + 1}: ");
                String gioiTinh = Console.ReadLine();

                Console.WriteLine($"Nhap tuoi khach hang thu {i + 1}: ");
                int tuoi = int.Parse(Console.ReadLine());

                Console.WriteLine($"Nhap ten chuyen : ");
                String tenChuyen = Console.ReadLine();

                Console.WriteLine($"Nhap ngay gio bay : ");
                DateTime ngayGioBay = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm",null);

                Console.WriteLine($"Nhap gia ve: ");
                int giaVe = int.Parse(Console.ReadLine());

                Console.WriteLine("So luong: ");
                int soLuong= int.Parse(Console.ReadLine()); 



                ConNguoi conNguoi = new ConNguoi(hoTen, gioiTinh, tuoi);
                Vemaybay ve = new Vemaybay(tenChuyen, ngayGioBay, giaVe);
                HanhKhach hanhKhach = new HanhKhach(hoTen, gioiTinh, tuoi, ve, soLuong);
                dsHanhKhach.Add(hanhKhach);

                
            }
            dsHanhKhach = dsHanhKhach.OrderBy(kh => kh.HoTen.Split(' ').Last()).ToList();


            Console.WriteLine("Danh sach thong tin khach hang la: ");
            foreach (HanhKhach khach in dsHanhKhach)
                {
                    Console.WriteLine($"Ho ten: {khach.HoTen}, gioi tinh: {khach.GioiTinh}, tuoi: {khach.Tuoi} Tong tien: {khach.tongTien()} VND");
                }
        }
    }
}
