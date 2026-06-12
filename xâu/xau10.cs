// Cho xâu s và ký tự c được nhập từ bàn phím
// Bạn hãy viết chương trình in ra số lần xuất hiện của ký tự c trong xâu s
using System;
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // nhập xâu từ bàn phím
            char c = char.Parse(Console.ReadLine()); // nhập ký tự từ bàn phím
            int answer = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    answer++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}