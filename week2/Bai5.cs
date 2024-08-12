using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week2
{
    internal class Bai5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Week2_Bai5");
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


            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
            int numMaxRow = arr2d[i,0];
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    if (arr2d[i, j] > numMaxRow)
                    {
                        numMaxRow = arr2d[i, j];
                    }
                }
                Console.WriteLine($"So lon nhat tren dong thu {i + 1} la: {numMaxRow}");

            }
            for (int j = 0; j < arr2d.GetLength(1); j++)
            {
            int numMinCol = arr2d[0,j];
                for (int i = 0; i < arr2d.GetLength(0); i++)
                {                
                    if (arr2d[j, i] < numMinCol)
                    {
                       numMinCol = arr2d[j, i];
                    }
                }
                Console.WriteLine($"So nho nhat tren cot thu {j + 1} la: {numMinCol}");

            }

        }
    }
}
