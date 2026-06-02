using System;

namespace Intput {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int Sum = 0;
            for ( int i = a; i <= b; i++)
            {
                Sum += i;
            }
            Console.Write(Sum);
        }
    }
}
