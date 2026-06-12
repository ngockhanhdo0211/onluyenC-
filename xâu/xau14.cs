// Cho xâu s được nhập vào từ bàn phím
// Bạn hãy viết chương trình hiển thị ra màn hình số các ký tự in hoa trong xâu s
using System;
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int answer = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    answer++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}