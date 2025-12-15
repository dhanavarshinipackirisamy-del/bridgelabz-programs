using System;

class FeetToYardsMiles
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter distance in feet:");
        double feet = Convert.ToDouble(Console.ReadLine());

        double yards = feet / 3;
        double miles = yards / 1760;

        Console.WriteLine(
            $"The distance is {yards} yards and {miles} miles for {feet} feet"
        );
    }
}
