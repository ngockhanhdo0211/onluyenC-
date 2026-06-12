// Cho hai xâu ký tự s1 và s2 được nhập vào từ bàn phím
// Bạn hãy viết chương trình hiển thị ra vị trí đầu tiên mà s2 xuất hiện trong s1
// Không phân biệt hoa thường
using System;
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            s1 = s1.ToLower(); // chuyển các xâu thành chữ thường
            s2 = s2.ToLower(); // chuyển các xâu thành chữ thường
            Console.WriteLine(s1.IndexOf(s2)); // câu này dùng để tìm vị trí
        }
    }
}