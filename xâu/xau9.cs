// Cho xâu s và số nguyên k được nhập từ bàn phím.
// Bạn hãy viết chương trình in ra màn hình ký tự thứ k trong xâu s
using System;
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // dòng này để nhập xâu
            int k = int.Parse(Console.ReadLine()); // dòng này nhập số nguyên
            Console.WriteLine(s[k - 1]); // do đề bài bảo lấy ký tự thứ k trong xâu s
            
        }
    }
}