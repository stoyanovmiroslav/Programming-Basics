using System;

class StopNumber
{
    static void Main()
    {
        var numberCups = double.Parse(Console.ReadLine());
        var numberWorkers = double.Parse(Console.ReadLine());
        var workDays = double.Parse(Console.ReadLine());

        var hoursWork = (workDays * 8) * numberWorkers;
        var cupsReady = hoursWork / 5;
        if (cupsReady > numberCups)
        {
            var result = (int)cupsReady - numberCups;
            result *= 4.2;
            Console.WriteLine("{0:f2} extra money", result);
        }
        else
        {
            var result = numberCups - cupsReady;
            result *= 4.2;
            Console.WriteLine("Losses: {0:f2}", result);
        }

    }
}