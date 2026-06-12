// cho một mảng các số nguyên n phần tử arr được nhập từ bàn phím. hãy tìm ra số lớn nhất trong mảng
using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // khai báo mảng
            int[] arr = new int[n];
            for( int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int maxValue = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}