using System;

class StopNumber
{
    static void Main()
    {
        var lekcii = double.Parse(Console.ReadLine());
        var money = double.Parse(Console.ReadLine());
        var Jelev = 0;
        var RoYaL = 0;
        var Trofon = 0;
        var Roli = 0;
        var Sino = 0;
        var Others = 0;
        for (int i = 0; i < lekcii; i++)
        {

            var names = Console.ReadLine();
            if (names == "Jelev") Jelev++;
            else if (names == "RoYaL") RoYaL++;
            else if (names == "Trofon") Trofon++;
            else if (names == "Roli") Roli++;
            else if (names == "Sino") Sino++;
            else Others++;
        }
        var sum = money / lekcii;
        Console.WriteLine("Jelev salary: {0:f2} lv", sum * Jelev);
        Console.WriteLine("RoYaL salary: {0:f2} lv", sum * RoYaL);
        Console.WriteLine("Roli salary: {0:f2} lv", sum * Roli);
        Console.WriteLine("Trofon salary: {0:f2} lv", sum * Trofon);
        Console.WriteLine("Sino salary: {0:f2} lv", sum * Sino);
        Console.WriteLine("Others salary: {0:f2} lv", sum * Others);


    }
}