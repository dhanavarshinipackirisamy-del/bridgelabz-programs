using System;

class TripDetails
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("From city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("To city: ");
        string toCity = Console.ReadLine();

        Console.Write("Distance from start to via (miles): ");
        double fromToVia = double.Parse(Console.ReadLine());

        Console.Write("Distance from via to final (miles): ");
        double viaToFinal = double.Parse(Console.ReadLine());

        Console.Write("Time taken (hours): ");
        double time = double.Parse(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinal;
        double speed = totalDistance / time;

        Console.WriteLine($"The results of the trip are Distance={totalDistance} miles, Time={time} hours, Speed={speed} mph");
    }
}
