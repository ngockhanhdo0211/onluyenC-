using System;
namespace Intput
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
        if ( n > 0)
        {
            for ( int i = n; i >= -n; i--)
            {
                Console.Write(i + " ");
            }
        }
        else {    
            for ( int i = n; i <= -n; i++)
            {
                Console.Write(i + " ");
                
            }
        }
        }

    }
}