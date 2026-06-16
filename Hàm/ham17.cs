// Viết pthuc hiển thị ra màn hình chia hết cho 3 mà kh chia hết cho 5
// Trong mảng các số nguyên arr được nhập vào từ bàn phím
using System;
namespace Method
{
    class Program
    {
        public static void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0 && arr[i] % 5 != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Show(arr);
        }
    }
}