// Hãy làm bài tập nhập 10 số từ bàn phím và tìm ra số nhỏ nhất trong 10 số đó
using System;
class Program
{
    static void Main()
    {
        int min = int.Parse(Console.ReadLine());
        for (int i = 2; i <= 10; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if ( n < min)
            {
                min = n;
            }
        }
        Console.WriteLine(min);
    }
}