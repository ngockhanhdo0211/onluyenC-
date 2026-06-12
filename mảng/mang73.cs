//Bài tập: Bạn hãy viết chương trình nhập vào từ bàn phím 10 số nguyên và hiển thị ra 10 số vừa nhập.
using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10]; // Khai báo mảng 
            // Dùng vòng for để nhập dữ liệu cho các phần tử trong mảng
            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            // Dùng vòng for để hiển thị các phần tử trong mảng
            for (int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}