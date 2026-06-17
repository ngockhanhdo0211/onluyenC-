// Cho số nguyên n được nhập từ bàn phím
// Bạn hãy viết phương thức đệ quy trả về tổng các số lẻ từ 1 tới n
using System;
namespace Method
{
    class Program
    {
        public static int Sum(int n)
        {
            if (n == 1) return 1;
            if (n % 2 == 0)
            {
                return Sum(n - 1);
            } else
            {
                return n + Sum(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(n));
        }
    }
}