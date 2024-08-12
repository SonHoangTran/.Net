namespace ConsoleApp1.week1
{
    internal class Bai2
    {
        int[] arr = new int[5];
        public int sumArray()
        {
            int result = 0;
           
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhap gia tri cua phan tu thu {i + 1}");
                arr[i] = int.Parse(Console.ReadLine());
                result += arr[i];
            }
            return result;
        }
        public static void MainBai2_w2(string[] args)
        {
            Bai2 b = new Bai2();
            b.sumArray();
        }
    }
}
