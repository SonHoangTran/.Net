using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week1
{
    internal class Bai4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap do dai cua mang: ");
            int n= int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int countSoChan = 0;
            int countSoLe = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Gia tri thu {i + 1} cua mang la: ");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    countSoChan++;
                }
                else
                {
                    countSoLe++;
                }
            }
                int[] arrSoChan = new int[countSoChan];
                int[] arrSoLe = new int[countSoLe];

                int soChan = 0, soLe = 0;
                for(int i=0; i < arr.Length;i++) {
                    if (arr[i] % 2 == 0)
                    {
                       arrSoChan[soChan++] = arr[i];
                    }
                    else
                    {
                        arrSoLe[soLe++] = arr[i]; 
                    }
                }
            Console.Write("Cac phan tu Chan trong mang: ");
            foreach (int item in arrSoChan)
            {
                Console.Write(item+ " ");
            }

            Console.Write("\nCac phan tu Le trong mang: ");
            foreach (int item in arrSoLe)
            {
                Console.Write(item + " ");
            }

        }
    }
}

