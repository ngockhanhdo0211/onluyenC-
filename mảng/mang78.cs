// Cho một mảng các số nguyên n phần tử arr. Bạn hãy viết chương trình tính tổng các số lẻ hơn 0 trong mảng.
using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai báo biến n và khai báo mảng
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] > 0)
                {
                    answer += arr[i];
                }
            }
            Console.Write(answer);
        }
    }
}