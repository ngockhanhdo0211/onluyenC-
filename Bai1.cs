// using System;

// namespace Input {
//     class Program {
//         static void Main(string[] args) {
//             // char c = char.Parse(Console.ReadLine());
//             // c++;
//             Console.WriteLine("Namdd");
//         }
//     }
// }
using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    Console.Write(j);

                    if (j < m)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}