
using System;

class TriangleArea
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter base:");
        double baseValue = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter height:");
        double heightValue = Convert.ToDouble(Console.ReadLine());

        double areaInInches = 0.5 * baseValue * heightValue;
        double areaInCm = areaInInches * 6.4516;

        Console.WriteLine(
            $"The area of triangle is {areaInInches} square inches and {areaInCm} square centimeters"
        );
    }
}
