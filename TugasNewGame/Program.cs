using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());

        // Daun
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= n - i; j++) {
                Console.Write(" ");
            }
            for (int k = 1; k <= (2 * i - 1); k++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n + 1; i++) {
            for (int j = 0; j < n - 1; j++) {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }
    }
}
