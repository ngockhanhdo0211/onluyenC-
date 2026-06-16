// Cho hình tròn có bán kính r được nhập từ bàn phím
//Bạn hãy viết phương thức trả về chu vi của hình tròn này biết pi = 3.14
using System;
namespace Method
{
    class Program
    {
        public static double Circumference(double r)
        {
            return 2 * r * 3.14;
        }
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(Circumference(r));
        }
    }
}