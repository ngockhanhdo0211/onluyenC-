using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            // if ( n > 0)
            // {
            //     int m = int.Parse(Console.ReadLine());
            //     //Console.WriteLine(n + m);
            // } else
            // {
            //     Console.WriteLine("hello a nam");
            // }
            // //int k = 99999999999999999999999999999;
            // for ( int i = 1; i <= n; i++)
            // {
            //     Console.Write(i);
            // }
            // for ( int i = 1; i <= m; i++)
            // {
            //     Console.Write(i);
            // }
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            for ( int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    // hàng 
                    Console.Write( " * " );
                    
                }
                // cột
               Console.WriteLine(); 
            }
            
            //11
            // 
            
            

            
        }
    }
}