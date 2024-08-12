using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week2
{
    internal class Bai4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Week2_Bai4");
            Console.Write("Nhap so dong cua mang: ");
            int Rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua mang: ");
            int Collumns = int.Parse(Console.ReadLine());

            int[,] arr2d = new int[Rows, Collumns];

            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    Console.Write($"Moi ban nhap phan phan tu arr2d[{i},{j}]: ");
                    arr2d[i, j] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("Cac phan tu cua mang la: \n ");
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {

                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    Console.Write((arr2d[i, j]) + " ");
                }
                Console.Write("\n");
            }


            int sum = 0;
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    Console.Write("\n");
                    if (j == 0 || j == arr2d.GetLength(1) - 1)
                    {
                        Console.Write($"Cac phan tu nam ngoai bien tai vi tri arr[{i},{j}] la: {arr2d[i, j]}");
                        sum += arr2d[i,j];
                    }
                }

            }
            Console.WriteLine($"\nTong cua cac so ngoai bien la: {sum}");
        }
    }
}
