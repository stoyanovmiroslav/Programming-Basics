using System;

class StopNumber
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var space = 0;
        var minus = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(@"{0}/{1}\{0}",
                              new string('.', 3 * n / 2 - 1 - minus),
                              new string(' ', space));
            space += 2;
            minus += 1;
        }
        Console.WriteLine("{0}{1}{0}",
                             new string('.', n / 2),
                             new string('*', 3 * n - n));
        for (int i = 0; i < n * 2; i++)
        {
            Console.WriteLine("{0}|{1}|{0}",
                new string('.', n / 2),
                new string('\\', 3 * n - n - 2));
        }
        minus = 0;
        space = 0;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(@"{0}/{1}\{0}",
                         new string('.', n / 2 - minus),
                         new string('*', 3 * n - n - 2 + space));
            minus += 1;
            space += 2;
        }
    }
}