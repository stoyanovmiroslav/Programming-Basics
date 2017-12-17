using System;

class StopNumber
{
    static void Main()
    {
        var amount = double.Parse(Console.ReadLine());
        var season = Console.ReadLine().ToLower();
        var persent = 0.00;
        var place = "";
        var city = "";

        if (amount <= 1000 && season == "summer")
        {
            city = "Alaska";
            place = "Camp";
            persent = 65;
        }
        else if (amount <= 1000 && season == "winter")
        {
            city = "Morocco";
            place = "Camp";
            persent = 45;
        }
        else if (amount <= 3000 && season == "summer")
        {
            city = "Alaska";
            place = "Hut";
            persent = 80;
        }
        else if (amount <= 3000 && season == "winter")
        {
            city = "Morocco";
            place = "Hut";
            persent = 60;
        }
        else if (amount > 3000 && season == "summer")
        {
            city = "Alaska";
            place = "Hotel";
            persent = 90;
        }
        else if (amount > 3000 && season == "winter")
        {
            city = "Morocco";
            place = "Hotel";
            persent = 90;
        }


        var price = amount * persent / 100;
        Console.WriteLine($"{city} - {place} - {price:f2}");


    }
}