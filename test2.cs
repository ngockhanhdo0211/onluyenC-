// Chỉ dùng 1 vòng lặp for, Nhập 10 số từ bàn phím, in ra giá trị lớn nhất trong 10 số đó.
using System;
class Program
{
    static void Main()
    {
        
        //int max = 0;
        Console.Write("Nhap so thu 1: ");
        int max = int.Parse(Console.ReadLine());
        for (int i = 2; i <= 10; i++) // lặp lại 10 lần 
        {
            //Console.Write(i);
            int n = int.Parse(Console.ReadLine());
            //sum += n; tính tổng ra 10 số nhập từ bàn phím 
            // // if(i == 1)
            // // {
            // //     max = n;
            // } else
            // {
            //     if (n > max)
            //     {
            //         max = n;
            //     }
            // }
            if (n > max)
            {
                max = n;
            }
        }
        Console.Write(max);
    }
}