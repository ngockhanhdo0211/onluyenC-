using System;
namespace Intput
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // for (int i = n; i <= 100; i++)
            // {
            //     if ( i % 2 == 0)
            //     {
            //         Console.Write(i + " ");
            //     }
            //}
            while ( n <= 100)
            {
                if ( n % 2 == 0)
                {
                    Console.Write(n + " ");
                }
                n += 1;
            }
        }
    }
}