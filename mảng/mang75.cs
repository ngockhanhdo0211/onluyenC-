// tính tổng của phần tử đầu và phần tử cuối ở trong mảng
using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
    {
        // khai báo biến nhập từ bàn phím
        int n = int.Parse(Console.ReadLine());
        // khai báo mảng
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            Console.Write(arr[0] + arr[n - 1]);

    }
    }
}