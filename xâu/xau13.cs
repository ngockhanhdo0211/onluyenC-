//Cho xâu s được nhập vào từ bàn phím
// Bạn hãy viết chương trình hiển thị ra màn hình những ký tự kh phỉa là số trong xâu s
using System;
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for(char c = '0'; c <= '9'; c++)
            {
                s = s.Replace(c + "", "");
            }
            Console.WriteLine(s);
        }
    }
}