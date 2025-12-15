using System;

class KmToMiles
{
    public static void Main(string[] args)
    {
        // Declare variable to store kilometers
        double km;

        // Ask user to enter kilometers
        Console.WriteLine("Enter distance in kilometers:");
        km = Convert.ToDouble(Console.ReadLine());

        // Conversion formula
        double miles = km / 1.6;

        // Display result
        Console.WriteLine(
            $"The total miles is {miles} mile for the given {km} km"
        );
    }
}

