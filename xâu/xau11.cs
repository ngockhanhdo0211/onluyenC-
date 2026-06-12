//Cho xâu s và ký tự c được nhập từ bàn phím
//Bạn hãy viết chương trình in ra vị trí đầu tiên mà ký tự c xuất hiện trong xâu s.
// Nếu ký tự c không xuất hiện trong s thì in ra -1
using System;
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // nhập chuỗi từ bàn phím
            char c = Char.Parse(Console.ReadLine()); // nhập ký tự từ bàn phím
            int answer = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c) // Kiểm tra ký tự tại vị trí i
                {
                    // Ta sẽ phải gọi lệnh beak để dừng vòng lặp do đã tìm tháy vị trí đầu tiên mà ký tự c xuất hiện
                    // Nếu không có lệnh break thì kết quả của chương trình sẽ là vị trí cuối cùng mà ký tự c xuất hiện
                    answer = i;
                    break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}