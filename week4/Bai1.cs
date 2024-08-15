
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.week4
{
    internal class Bai1
    {

        delegate int Caculator(int num1, int num2);
        public static void Main(string[] args)
        {
            Caculator caculatorMax = new Caculator(maxNumber);

            Caculator caculatorSum = new Caculator(addNumber);

            Caculator caculatorSub = new Caculator(subNumber);

            Caculator caculatorMulti = new Caculator(multiNumber);

            Caculator caculatorDiv = new Caculator(divideNumber);




            int result1 = caculatorMax(10, 4);

            int result2 = caculatorSum(10, 4);

            int result3 = caculatorSub(10, 40);

            int result4 = caculatorMulti(10, 4);

            int result5 = caculatorDiv(10, 4);


            Console.WriteLine("So lon nhat la: " + result1);
            Console.WriteLine("Tong hai so la: " + result2);
            Console.WriteLine("Hieu hai so la: " + result3);
            Console.WriteLine("Tich hai so la: " + result4);
            Console.WriteLine("Thuong hai so la: " + result5);


            // Console.WriteLine($"{result1} + {result2}");


            //khi thuc hien phep cong delegate thi se tao ra 1 delegate moi de chay hai ham lien tiep nhung chi tra ve ket qua cua ham cuoi cung duoc goi

            Console.WriteLine("Thuc hien hai ham delegte lien tuc: ");
            Caculator caculator = caculatorSum + caculatorMax;
            int result = caculator(10, 12);
            Console.WriteLine(result);
           

            static int maxNumber(int num1, int num2)
            {
                if (num1 >= num2)
                {
                    return num1;
                }
                else
                {
                    return num2;
                }
            }

            static int addNumber(int num1, int num2)
            {
                return num1 + num2;
            }

            static int subNumber(int num1, int num2)
            {
                return Math.Abs(num1 - num2);
            }

            static int multiNumber(int num1, int num2)
            {
               return num1 * num2;
            }

            static int divideNumber(int num1, int num2)
            {
                return num1 / num2;
            }
        }
    }
}
