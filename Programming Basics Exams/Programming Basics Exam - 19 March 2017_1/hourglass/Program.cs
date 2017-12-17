using System;

class StopNumber
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var minus2 = 0;
        Console.WriteLine("{0}", new string('*', 2 * n + 1));
        Console.WriteLine(".*{0}*.",
                            new string(' ', (2 * n + 1) - 4));
        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                           new string('.', 1 + i),
                           new string('@', (n * 2 + 1) - ((2 + i) * 2)));
            minus2 += 2;
        }
        Console.WriteLine("{0}*{0}",
                           new string('.', n));
        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("{0}*{1}@{1}*{0}",
                          new string('.', n - i),
                          new string(' ', i - 1));


        }
        Console.WriteLine(".*{0}*.",
                        new string('@', (2 * n + 1) - 4));
        Console.WriteLine("{0}", new string('*', 2 * n + 1));

    }
}