using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week1
{
    internal class Bai1
    {
        int[] arr1 = new int[5];

        public void addDigitToArray()
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"Phan tu gia tri thu {i + 1}: ");
                arr1[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("\nCác phan tu trong mang theo thu tu là: ");

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();

        }
        public static void MainBai1_w1(string[] args)
        {
            Bai1 myClass = new Bai1();
            myClass.addDigitToArray();
        }
    }


}


