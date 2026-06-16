// Bạn hãy viết phương thức trả về số lớn nhất trong 3 số được nhập từ bàn phím
using System;
namespace Method
{
    class Program
    {
        public static int Max3(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            if (b >= c)
            {
                return b;
            }
            return c;
            
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.Write(Max3(a, b, c));
        }
    }
}