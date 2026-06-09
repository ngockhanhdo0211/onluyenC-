// Nhập số n từ bàn phím, n là số lượng phần tử của mảng a, nhập tất cả các phần tử của mảng a từ bàn phím tìm số nhỏ nhất trong mảng a
// Lớn nhất trong mảng a
// Tổng của mảng a 
using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n]; // khai báo mảng
        // nhập mảng
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        // Gán giá trị
        int sum = 0;
        int max = a[0];
        int min = a[0];
        // duyệt mảng để tính tổng, lớn nhất, nhỏ nhất
        for (int i = 0; i < n; i++)
        {
            sum += a[i];
            if (a[i] > max)
            {
                max = a[i];
            }
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        Console.WriteLine(sum);
        Console.WriteLine(max);
        Console.WriteLine(min);
        
    }
}