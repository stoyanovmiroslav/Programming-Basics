using System;

class StopNumber
{
    static void Main()
    {
        var hHouse = double.Parse(Console.ReadLine());
        var wSideWall = double.Parse(Console.ReadLine());
        var hTriangle = double.Parse(Console.ReadLine());

        var sideWall = ((hHouse * wSideWall) * 2) - (2 * 2.25);
        var backFrontWall = 2 * (hHouse * hHouse) - 2.4;
        var obshtaPlosht = sideWall + backFrontWall;
        var greenPain = obshtaPlosht / 3.4;

        var pokriv = 2 * (hHouse * wSideWall);
        var triangleRoof = 2 * (hHouse * hTriangle / 2);
        var obshtaPloshtRoof = pokriv + triangleRoof;
        var redPain = obshtaPloshtRoof / 4.3;

        Console.WriteLine("{0:f2}", greenPain);

        Console.WriteLine("{0:f2}", redPain);



    }
}