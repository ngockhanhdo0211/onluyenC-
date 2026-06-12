// Cho xâu s được nhập và từ bàn phím
// Bạn hãy viết chương trình đảo ngược xâu s và hiển thị ra màn hình
using System;
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}