using System;

class StopNumber
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var lastNumber = int.Parse(Console.ReadLine());
        var magicNumber = int.Parse(Console.ReadLine());
        var combination = 0;

        for (int i = firstNumber; i >= lastNumber; i--)
        {
            for (int j = firstNumber; j >= lastNumber; j--)
            {
                combination++;
                if (i + j == magicNumber)
                {
                    Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNumber})");
                    return;
                }

            }
        }
        Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");

    }
}