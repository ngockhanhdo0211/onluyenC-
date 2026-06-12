// Cho một mảng các số nguyên n phần tử arr. Bạn hãy viết chương trình sắp xếp các phần tử của mảng theo thứ tự tăng dần và hiển thị ra màn hình mảng sau khi đã sắp xếp
using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for( int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi vị trí cho nhau
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}