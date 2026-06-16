// Bạn hãy viết phương thức trả về tổng của các phần tử trong mảng các số nguyên arr
// Được nhập từ bàn phím
using System;
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(SumOfArray(arr));
        }
        public static int SumOfArray(int[] arr)
        {
            int answer = 0;
            for(int i = 0; i< arr.Length; i++)
            {
                answer += arr[i];
            }
            return answer;
        }
    }
}