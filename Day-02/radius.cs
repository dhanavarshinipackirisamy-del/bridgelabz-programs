using System;

class EarthVolume
{
    public static void Main(string[] args)
    {
        double radiusKm = 6378;
        double pi = Math.PI;

        double volumeKm = (4.0 / 3.0) * pi * radiusKm * radiusKm * radiusKm;

        double kmToMiles = 0.621371;
        double volumeMiles = volumeKm * kmToMiles * kmToMiles * kmToMiles;

        Console.WriteLine(
            $"The volume of earth in cubic kilometers is {volumeKm} and cubic miles is {volumeMiles}"
        );
    }
}
