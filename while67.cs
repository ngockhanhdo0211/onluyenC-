using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int answer = 1;
			while (b > 0) {
				answer *= a;
				b--;
			}
			Console.Write(answer);
		}
    }
}