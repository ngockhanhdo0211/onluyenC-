// Chỉ dùng 1 vòng lặp for, Nhập 10 số từ bàn phím, in ra giá trị lớn nhất trong 10 số đó.
using System;
class Program
{
    static void Main()
    {
        int max = int.Parse(Console.ReadLine());
        for (int i = 2; i <= 10; i++) // lặp lại 10 lần 
        {
            int n = int.Parse(Console.ReadLine());           
            if (n > max)
            {
                max = n;
            }
        }
        Console.Write(max);
    }
}