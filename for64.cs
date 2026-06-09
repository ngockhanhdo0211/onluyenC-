using System;

class Program
{
    static void Main(string[] args)
    {
        
        for (int i = 0; i < 25; i++)
         {
             Console.Write(i + " ");
             // (i % 5 == 0)
             if ((i + 1 ) % 5 == 0)
             {
                Console.WriteLine();
             }
       //onsole.Write(i % 5 + " ");
         }

    }
}