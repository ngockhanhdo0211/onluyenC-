//Cho số nguyên dương n được nhập từ bàn phím
// Bạn hãy viết phương thức đệ quy trả về n! ( n giai thừa)
using System;
namespace Method
{
    class Program
    {
        public static int Factorial(int n)
        {
            if ( n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
    }
}