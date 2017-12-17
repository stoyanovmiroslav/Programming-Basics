using System;

class StopNumber
{
    static void Main()
    {
        var money = double.Parse(Console.ReadLine());
        var year = double.Parse(Console.ReadLine());

        var years = year - 1800;

        for (int i = 0; i <= years; i++)
        {
            if (i % 2 == 0)
            {
                money = money - 12000;
            }
            else
            {
                money = money - (12000 + (50 * (18 + i)));

            }

        }

        if (money >= 0)
            Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
        else
            Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money));
    }
}