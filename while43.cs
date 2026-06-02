using System;
namespace IntPut
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;          
            while (i <= n)
            {
                if ( n % i == 0)
                {
                    sum++;
                }
                i++;
            }
            Console.Write(sum);
        }
    }
}