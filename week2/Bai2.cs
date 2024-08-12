using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week2
{
    internal class Bai2
    {
        /*
        public static void Main(string[] args)
        {
            int[,] array2d = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 6, 7 }, { 7, 8 }, { 8, 9 }, { 9, 10 } };
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write(array2d[i, j]+" ");
                }
            }

        }  
        */
        public static void Main(string[] args)
        {
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

            int sumRow = 0;
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    sumRow += arr2d[i, j];
                }
                Console.Write(($"Tong cua hang thu {i} la: {sumRow}"));
                sumRow = 0;
            }


        }
    }
}
