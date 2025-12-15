using System;

class ConvertDistance
{
    public static void Main(string[] args)
    {
        double kilometers = 10.8;
        double kmToMiles = 1.6;

        double miles = kilometers / kmToMiles;

        Console.WriteLine(
            $"The distance {kilometers} km in miles is {miles}"
        );
    }
}
