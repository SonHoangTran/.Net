using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week1
{
    internal class Bai3
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, };          
                int[] arr2 = new int[arr1.Length];
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = arr1[i];
                }

            Console.Write("Cac gia tri cua mang sau khi duoc gan la: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]+" ");
            }
            
            
        }
        
       
    }
}
